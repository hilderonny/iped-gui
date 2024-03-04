using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Text.Json;

namespace IPED_Gui_WinForms.Messages
{
    public class MessageHandler
    {

        private CoreWebView2 webView;

        public MessageHandler(CoreWebView2 wv)
        {
            webView = wv;
        }

        public void handleMessage(string jsonMessage)
        {
            WebClientMessage? parsedMessage = JsonSerializer.Deserialize<WebClientMessage>(jsonMessage);
            if (parsedMessage != null)
            {
                switch (parsedMessage.Type)
                {
                    case "ReadTextFile": handleReadTextFileMessage(parsedMessage); break;
                    case "ReadTextFileDialog": handleReadTextFileDialogMessage(parsedMessage); break;
                    case "RunProgram": handleRunProgramMessage(parsedMessage); break;
                    case "SelectFile": handleSelectFileMessage(parsedMessage); break;
                    case "SelectPath": handleSelectPathMessage(parsedMessage); break;
                    case "WriteTextFile": handleWriteTextFileMessage(parsedMessage); break;
                    case "WriteTextFileDialog": handleWriteTextFileDialogMessage(parsedMessage); break;
                }
            }
        }

        private void handleReadTextFileMessage(WebClientMessage message)
        {
            string? filePath = message.Path;
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Content = fileContent
                };
                PostMessage(response);
            }
        }

        private void handleReadTextFileDialogMessage(WebClientMessage message)
        {
            OpenFileDialog dialog = new()
            {
                Filter = message.FileFilter
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(dialog.FileName);
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Content = fileContent
                };
                PostMessage(response);
            }
        }

        private void handleRunProgramMessage(WebClientMessage message)
        {
            Process process = new()
            {
                StartInfo = new()
                {
                    FileName = message.Program,
                    UseShellExecute = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = message.ProgramArguments
                }
            };
            DataReceivedEventHandler dataReceivedEventHandler = (object sender, DataReceivedEventArgs args) =>
            {
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Type = "LogOutput",
                    Content = args.Data
                };
                PostMessage(response);

            };
            process.OutputDataReceived += dataReceivedEventHandler;
            process.ErrorDataReceived += dataReceivedEventHandler;
            process.Exited += (sender, args) =>
            {
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Type = "ProcessFinished"
                };
                PostMessage(response);
            };
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        private void handleSelectFileMessage(WebClientMessage message)
        {
            OpenFileDialog dialog = new()
            {
                Filter = message.FileFilter
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Path = dialog.FileName
                };
                PostMessage(response);
            }
        }

        private void handleSelectPathMessage(WebClientMessage message)
        {
            FolderBrowserDialog dialog = new ();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Path = dialog.SelectedPath
                };
                PostMessage(response);
            }
        }

        private void handleWriteTextFileMessage(WebClientMessage message)
        {
            string? filePath = message.Path;
            if (filePath != null)
            {
                File.WriteAllText(filePath, message.Content);
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Path = filePath
                };
                PostMessage(response);
            }
        }

        private void handleWriteTextFileDialogMessage(WebClientMessage message)
        {
            SaveFileDialog dialog = new()
            {
                AddExtension = true,
                Filter = message.FileFilter
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, message.Content);
                WebClientMessage response = new()
                {
                    Id = message.Id,
                    Path = dialog.FileName
                };
                PostMessage(response);
            }
        }

        private void PostMessage(WebClientMessage message)
        {
            string json = JsonSerializer.Serialize(message);
            webView.PostWebMessageAsJson(json);
        }

    }
}
