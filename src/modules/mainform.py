import PySimpleGUI as sg
import modules.config as cfg

def createHomeTab():
    return sg.Tab(title='Home', layout=[
        [
            sg.InputText(key="-FILENAME-", readonly=True, expand_x=True, enable_events=True), 
            sg.FileBrowse(button_text="Datei auswählen ...", target="-FILENAME-")
        ],
        [
            sg.Text(text="Whisper-Modell:"), 
            sg.Radio(text="Tiny", group_id="MODELL", key="-MODELTINY-"),
            sg.Radio(text="Base", group_id="MODELL", key="-MODELBASE-"),
            sg.Radio(text="Small", group_id="MODELL", key="-MODELSMALL-", default=True),
            sg.Radio(text="Medium", group_id="MODELL", key="-MODELMEDIUM-"),
            sg.Radio(text="Large V2", group_id="MODELL", key="-MODELLARGEV2-")
        ],
        [
            sg.Button(button_text="Transkription starten", key="-STARTEN-", disabled=True)
        ],
        [
            sg.ProgressBar(max_value=6, orientation="horizontal", size=(20, 20), key="-PROGRESSBAR-", expand_x=True)
        ],
        [
            sg.Multiline(size=(45, 5), key="-OUTPUT-", expand_x=True, expand_y=True, font=("Courier New", 12))
        ],
        [
            sg.InputText(key="-SPEICHERN-", do_not_clear=False, enable_events=True, visible=False), 
            sg.FileSaveAs(button_text="Protokoll speichern unter ...", target="-SPEICHERN-", file_types=(("Text", ".txt"),))
        ]
    ])

def createEnvironmentTab():
    return sg.Tab(title='Environment', layout=[
        [
            sg.Text(text='locale', size=(15,1), tooltip="Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'"),
            sg.Combo(key='environment-locale', values=['en', 'pt-BR', 'it-IT', 'de-DE', 'es-AR'], default_value=cfg.getConfig('environment', 'locale', 'de-DE'), enable_events=True)
        ],
        [
            sg.Text(text='indexTemp', size=(15,1), tooltip='Temporary directory for processing: "default" uses the system temporary folder. Configure it on a folder free of antivirus, system indexing or restoring. Using a SSD disk is highly recommended.'),
            sg.Input(key='environment-indextemp', default_text=cfg.getConfig('environment', 'indextemp', ''), readonly=True, enable_events=True),
            sg.FolderBrowse(button_text='Choose folder ...', target='environment-indextemp')
        ],
        [
            sg.Text(text='indexTempOnSSD', size=(15,1), tooltip='Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you will have performance problems.'),
            sg.Checkbox(key='environment-indextemponssd', text='', default=(cfg.getConfig('environment', 'indextemponssd', 'False') == 'True'), enable_events=True)
        ],
        [
            sg.Text(text='outputOnSSD', size=(15,1), tooltip='Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp folder.'),
            sg.Checkbox(key='environment-outputonssd', text='', default=(cfg.getConfig('environment', 'outputonssd', 'False') == 'True'), enable_events=True)
        ],
        [
            sg.Text(text='numThreads', size=(15,1), tooltip='Number of processing threads/workers: "default" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms).'),
            sg.Input(key='environment-numthreads', default_text=cfg.getConfig('environment', 'numthreads', 'default'), enable_events=True)
        ],
        [
            sg.Text(text='hashesDB', size=(15,1), tooltip='Full path for IPED hash database. It is highly recommended to store it on a fast disk,  preferably SSD, and not the same used as "indexTemp", if other disk is available.'),
            sg.Input(key='environment-hashesdb', default_text=cfg.getConfig('environment', 'hashesdb', ''), enable_events=True),
            sg.FileBrowse(button_text='Select file ...', target='environment-hashesdb')
        ],
        [
            sg.Text(text='pluginFolder', size=(15,1), tooltip='Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime.'),
            sg.Input(key='environment-pluginfolder', default_text=cfg.getConfig('environment', 'pluginfolder', ''), enable_events=True),
            sg.FolderBrowse(button_text='Choose folder ...', target='environment-pluginfolder')
        ],
    ])

def createProcessingTab():
    return sg.Tab(title='Processing', layout=[
        [
            sg.Text('Processing')
        ]
    ])

def createTaskTab():
    return sg.Tab(title='Tasks', layout=[
        [
            sg.Text('Tasks')
        ]
    ])

def createmainform(version):
    layout = [
        [
            sg.TabGroup(expand_x=True, expand_y=True, layout=[
                [
                    #createHomeTab(),
                    createEnvironmentTab(),
                    createProcessingTab(),
                    createTaskTab()
                ]
            ])
        ],
    ]
    window = sg.Window(title="Transkription und Übersetzung - " + version, layout=layout, size=(1000,700), resizable=True, element_justification="center", finalize=True)
    return window