using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Data
{
    public class Category
    {

        public readonly static Category Root = new()
        {
            SubCategories = new List<Category>
            {
                new() { Name = "Documents", Icon = Resources.Documents, SettingsKey = "CategoriesToExportDocuments", SubCategories = new List<Category>
                {
                    new() { Name = "RTF Documents", Icon = Resources.RTF_Documents, SettingsKey = "CategoriesToExportRTFDocuments" },
                    new() { Name = "PDF Documents", Icon = Resources.PDF_Documents, SettingsKey = "CategoriesToExportPDFDocuments" },
                    new() { Name = "HTML Documents", Icon = Resources.HTML_Documents, SettingsKey = "CategoriesToExportHTMLDocuments" },
                    new() { Name = "Text Documents", Icon = Resources.Text_Documents, SettingsKey = "CategoriesToExportTextDocuments" },
                    new() { Name = "Other Documents", Icon = Resources.Other_Documents, SettingsKey = "CategoriesToExportOtherDocuments" },
                }},
                new() { Name = "XML Files", Icon = Resources.XML_Files, SettingsKey = "CategoriesToExportXMLFiles" },
                new() { Name = "Georeferenced Files", Icon = Resources.Georeferenced_Files, SettingsKey = "CategoriesToExportGeoreferencedFiles" },
                new() { Name = "Spreadsheets", Icon = Resources.Spreadsheets, SettingsKey = "CategoriesToExportSpreadsheets" },
                new() { Name = "Presentations", Icon = Resources.Presentations, SettingsKey = "CategoriesToExportPresentations" },
                new() { Name = "OLE files", Icon = Resources.OLE_files, SettingsKey = "CategoriesToExportOLEfiles" },
                new() { Name = "Links", Icon = Resources.Links, SettingsKey = "CategoriesToExportLinks", SubCategories = new List<Category>
                {
                    new() { Name = "Link files", Icon = Resources.Link_files, SettingsKey = "CategoriesToExportLinkfiles" },
                    new() { Name = "URL links", Icon = Resources.URL_links, SettingsKey = "CategoriesToExportURLlinks" },
                }},
                new() { Name = "Emails and Mailboxes", Icon = Resources.Emails_and_Mailboxes, SettingsKey = "CategoriesToExportEmailsandMailboxes", SubCategories = new List<Category>
                {
                    new() { Name = "Mailboxes", Icon = Resources.Mailboxes, SettingsKey = "CategoriesToExportMailboxes" },
                    new() { Name = "Emails", Icon = Resources.Emails, SettingsKey = "CategoriesToExportEmails" },
                    new() { Name = "Appointments", Icon = Resources.Appointments, SettingsKey = "CategoriesToExportAppointments" },
                    new() { Name = "Win10 Mail App Additional Info", Icon = Resources.Win10_Mail_Info, SettingsKey = "CategoriesToExportWin10MailAppAdditionalInfo" },
                }},
                new() { Name = "Multimedia", Icon = Resources.Multimedia, SettingsKey = "CategoriesToExportMultimedia", SubCategories = new List<Category>
                {
                    new() { Name = "Audios", Icon = Resources.Audios, SettingsKey = "CategoriesToExportAudios" },
                    new() { Name = "Videos", Icon = Resources.Videos, SettingsKey = "CategoriesToExportVideos" },
                    new() { Name = "Video Thumbnails", Icon = Resources.Video_Thumbnails, SettingsKey = "CategoriesToExportVideoThumbnails" },
                    new() { Name = "Images", Icon = Resources.Images, SettingsKey = "CategoriesToExportImages", SubCategories = new List<Category>
                    {
                        new() { Name = "Temporary Internet Images", Icon = Resources.Temporary_Internet_Images, SettingsKey = "CategoriesToExportTemporaryInternetImages" },
                        new() { Name = "Images in System Folders", Icon = Resources.Images_in_System_Folders, SettingsKey = "CategoriesToExportImagesinSystemFolders" },
                        new() { Name = "Other Images", Icon = Resources.Other_Images, SettingsKey = "CategoriesToExportOtherImages" },
                        new() { Name = "Scanned Documents", Icon = Resources.Scanned_Documents, SettingsKey = "CategoriesToExportScannedDocuments" },
                    }},
                }},
                new() { Name = "Windows Artifacts", Icon = Resources.Windows_Artifacts, SettingsKey = "CategoriesToExportWindowsArtifacts", SubCategories = new List<Category>
                {
                    new() { Name = "Event Files", Icon = Resources.Event_Files, SettingsKey = "CategoriesToExportEventFiles" },
                    new() { Name = "Event Records", Icon = Resources.Event_Records, SettingsKey = "CategoriesToExportEventRecords" },
                    new() { Name = "Prefetch and Superfetch", Icon = Resources.Prefetch_and_Superfetch, SettingsKey = "CategoriesToExportPrefetchandSuperfetch" },
                    new() { Name = "User Activities", Icon = Resources.User_Activities, SettingsKey = "CategoriesToExportUserActivities" },
                    new() { Name = "User Activities Entries", Icon = Resources.User_Activities_Entries, SettingsKey = "CategoriesToExportUserActivitiesEntries" },
                    new() { Name = "Windows Registry", Icon = Resources.Windows_Registry, SettingsKey = "CategoriesToExportWindowsRegistry", SubCategories = new List<Category>
                    {
                        new() { Name = "Main Registry Files", Icon = Resources.Main_Registry_Files, SettingsKey = "CategoriesToExportMainRegistryFiles" },
                        new() { Name = "Other Registry Files", Icon = Resources.Other_Registry_Files, SettingsKey = "CategoriesToExportOtherRegistryFiles" },
                        new() { Name = "Registry Full Reports", Icon = Resources.Registry_Full_Reports, SettingsKey = "CategoriesToExportRegistryFullReports" },
                        new() { Name = "Registry Custom Reports", Icon = Resources.Registry_Custom_Reports, SettingsKey = "CategoriesToExportRegistryCustomReports", SubCategories = new List<Category>
                        {
                            new() { Name = "Registry OS Info", Icon = Resources.Registry_OS_Info, SettingsKey = "CategoriesToExportRegistryOSInfo" },
                            new() { Name = "Registry Installed Apps", Icon = Resources.Registry_Installed_Apps, SettingsKey = "CategoriesToExportRegistryInstalledApps" },
                            new() { Name = "Registry Network Info", Icon = Resources.Registry_Network_Info, SettingsKey = "CategoriesToExportRegistryNetworkInfo" },
                            new() { Name = "Registry Storage Info", Icon = Resources.Registry_Storage_Info, SettingsKey = "CategoriesToExportRegistryStorageInfo" },
                            new() { Name = "Registry Device Info", Icon = Resources.Registry_Device_Info, SettingsKey = "CategoriesToExportRegistryDeviceInfo" },
                            new() { Name = "Registry Program Run", Icon = Resources.Registry_Program_Run, SettingsKey = "CategoriesToExportRegistryProgramRun" },
                            new() { Name = "Registry Auto Run", Icon = Resources.Registry_Auto_Run, SettingsKey = "CategoriesToExportRegistryAutoRun" },
                            new() { Name = "Registry Log Info", Icon = Resources.Registry_Log_Info, SettingsKey = "CategoriesToExportRegistryLogInfo" },
                            new() { Name = "Registry Malware Info", Icon = Resources.Registry_Malware_Info, SettingsKey = "CategoriesToExportRegistryMalwareInfo" },
                            new() { Name = "Registry Web Info", Icon = Resources.Registry_Web_Info, SettingsKey = "CategoriesToExportRegistryWebInfo" },
                            new() { Name = "Registry User Info", Icon = Resources.Registry_User_Info, SettingsKey = "CategoriesToExportRegistryUserInfo", SubCategories = new List<Category>
                            {
                                new() { Name = "Registry User Accounts", Icon = Resources.Registry_User_Accounts, SettingsKey = "CategoriesToExportRegistryUserAccounts" },
                                new() { Name = "Registry User Activity", Icon = Resources.Registry_User_Activity, SettingsKey = "CategoriesToExportRegistryUserActivity" },
                                new() { Name = "Registry User Files", Icon = Resources.Registry_User_Files, SettingsKey = "CategoriesToExportRegistryUserFiles" },
                                new() { Name = "Registry User Network Activity", Icon = Resources.Registry_User_Network_Activity, SettingsKey = "CategoriesToExportRegistryUserNetworkActivity" },
                                new() { Name = "Registry User Config", Icon = Resources.Registry_User_Config, SettingsKey = "CategoriesToExportRegistryUserConfig" },
                                new() { Name = "Registry User Virtualization", Icon = Resources.Registry_User_Virtualization, SettingsKey = "CategoriesToExportRegistryUserVirtualization" },
                                new() { Name = "Registry User Communication", Icon = Resources.Registry_User_Communication, SettingsKey = "CategoriesToExportRegistryUserCommunication" },
                            }},
                        }},
                    }},
                }},
                new() { Name = "Google Drive", Icon = Resources.Google_Drive, SettingsKey = "CategoriesToExportGoogleDrive", SubCategories = new List<Category>
                {
                    new() { Name = "GDrive Synced Files", Icon = Resources.GDrive_Synced_Files, SettingsKey = "CategoriesToExportGDriveSyncedFiles" },
                    new() { Name = "GDrive File Entries", Icon = Resources.GDrive_File_Entries, SettingsKey = "CategoriesToExportGDriveFileEntries" },
                }},
                new() { Name = "Databases", Icon = Resources.Databases, SettingsKey = "CategoriesToExportDatabases" },
                new() { Name = "Compressed Archives", Icon = Resources.Compressed_Archives, SettingsKey = "CategoriesToExportCompressedArchives" },
                new() { Name = "Contacts", Icon = Resources.Contacts, SettingsKey = "CategoriesToExportContacts" },
                new() { Name = "Chats", Icon = Resources.Chats, SettingsKey = "CategoriesToExportChats", SubCategories = new List<Category>
                {
                    new() { Name = "WhatsApp", Icon = Resources.Whatsapp, SettingsKey = "CategoriesToExportWhatsApp" },
                    new() { Name = "Messenger", Icon = Resources.Messenger, SettingsKey = "CategoriesToExportMessenger" },
                    new() { Name = "Skype", Icon = Resources.Skype, SettingsKey = "CategoriesToExportSkype" },
                    new() { Name = "Telegram", Icon = Resources.Telegram, SettingsKey = "CategoriesToExportTelegram" },
                    new() { Name = "Jabber", Icon = Resources.Jabber, SettingsKey = "CategoriesToExportJabber" },
                    new() { Name = "Facebook", Icon = Resources.Facebook, SettingsKey = "CategoriesToExportFacebook" },
                    new() { Name = "Instagram", Icon = Resources.Instagram, SettingsKey = "CategoriesToExportInstagram" },
                    new() { Name = "Discord", Icon = Resources.Discord, SettingsKey = "CategoriesToExportDiscord" },
                    new() { Name = "Chat Activities", Icon = Resources.Chat_Activities, SettingsKey = "CategoriesToExportChatActivities" },
                    new() { Name = "Others Chats", Icon = Resources.Others_Chats, SettingsKey = "CategoriesToExportOthersChats" },
                }},
                new() { Name = "USN Journal", Icon = Resources.USN_Journal, SettingsKey = "CategoriesToExportUSNJournal" },
                new() { Name = "Programs and Libraries", Icon = Resources.Programs_and_Libraries, SettingsKey = "CategoriesToExportProgramsandLibraries" },
                new() { Name = "Unallocated", Icon = Resources.Unallocated, SettingsKey = "CategoriesToExportUnallocated" },
                new() { Name = "File Slacks", Icon = Resources.File_Slacks, SettingsKey = "CategoriesToExportFileSlacks" },
                new() { Name = "Plain Texts", Icon = Resources.Plain_Texts, SettingsKey = "CategoriesToExportPlainTexts", SubCategories = new List<Category>
                {
                    new() { Name = "Temporary Internet Texts", Icon = Resources.Temporary_Internet_Texts, SettingsKey = "CategoriesToExportTemporaryInternetTexts" },
                    new() { Name = "Texts in System Folders", Icon = Resources.Texts_in_System_Folders, SettingsKey = "CategoriesToExportTextsinSystemFolders" },
                    new() { Name = "Other Texts", Icon = Resources.Other_Texts, SettingsKey = "CategoriesToExportOtherTexts" },
                }},
                new() { Name = "Other files", Icon = Resources.Other_files, SettingsKey = "CategoriesToExportOtherfiles" },
                new() { Name = "Peer-to-peer", Icon = Resources.Peer_to_peer, SettingsKey = "CategoriesToExportPeertopeer", SubCategories = new List<Category>
                {
                    new() { Name = "Ares Galaxy", Icon = Resources.Ares_Galaxy, SettingsKey = "CategoriesToExportAresGalaxy" },
                    new() { Name = "E-Mule", Icon = Resources.E_Mule, SettingsKey = "CategoriesToExportEMule" },
                    new() { Name = "Shareaza", Icon = Resources.Shareaza, SettingsKey = "CategoriesToExportShareaza" },
                    new() { Name = "Torrent", Icon = Resources.Torrent, SettingsKey = "CategoriesToExportTorrent" },
                    new() { Name = "Other Peer-to-peer", Icon = Resources.Peer_to_peer, SettingsKey = "CategoriesToExportOtherPeertopeer" },
                }},
                new() { Name = "Browser Artifacts", Icon = Resources.Browser_Artifacts, SettingsKey = "CategoriesToExportBrowserArtifacts", SubCategories = new List<Category>
                {
                    new() { Name = "Internet History", Icon = Resources.Internet_History, SettingsKey = "CategoriesToExportInternetHistory" },
                    new() { Name = "Internet History Entries", Icon = Resources.Internet_History_Entries, SettingsKey = "CategoriesToExportInternetHistoryEntries" },
                    new() { Name = "Web Bookmarks", Icon = Resources.Web_Bookmarks, SettingsKey = "CategoriesToExportWebBookmarks" },
                    new() { Name = "Mozilla Firefox Saved Session", Icon = Resources.Mozilla_Firefox_Saved_Session, SettingsKey = "CategoriesToExportMozillaFirefoxSavedSession" },
                    new() { Name = "TorTCFragment", Icon = Resources.TorTCFragment, SettingsKey = "CategoriesToExportTorTCFragment" },
                }},
                new() { Name = "Image Disks", Icon = Resources.Image_Disks, SettingsKey = "CategoriesToExportImageDisks", SubCategories = new List<Category>
                {
                    new() { Name = "ISO disks", Icon = Resources.ISO_disks, SettingsKey = "CategoriesToExportISOdisks" },
                    new() { Name = "Virtual disks", Icon = Resources.Virtual_disks, SettingsKey = "CategoriesToExportVirtualdisks" },
                    new() { Name = "Other disks", Icon = Resources.Other_disks, SettingsKey = "CategoriesToExportOtherdisks" },
                }},
                new() { Name = "Extraction Summary", Icon = Resources.Extraction_Summary, SettingsKey = "CategoriesToExportExtractionSummary" },
                new() { Name = "Calls", Icon = Resources.Calls, SettingsKey = "CategoriesToExportCalls" },
                new() { Name = "SMS Messages", Icon = Resources.SMS_Messages, SettingsKey = "CategoriesToExportSMSMessages" },
                new() { Name = "MMS Messages", Icon = Resources.MMS_Messages, SettingsKey = "CategoriesToExportMMSMessages" },
                new() { Name = "Instant Messages", Icon = Resources.Instant_Messages, SettingsKey = "CategoriesToExportInstantMessages" },
                new() { Name = "Bluetooth Devices", Icon = Resources.Bluetooth_Devices, SettingsKey = "CategoriesToExportBluetoothDevices" },
                new() { Name = "SIM Data", Icon = Resources.SIM_Data, SettingsKey = "CategoriesToExportSIMData" },
                new() { Name = "Calendar", Icon = Resources.Calendar, SettingsKey = "CategoriesToExportCalendar" },
                new() { Name = "Logs", Icon = Resources.Logs, SettingsKey = "CategoriesToExportLogs" },
                new() { Name = "User Accounts", Icon = Resources.User_Accounts, SettingsKey = "CategoriesToExportUserAccounts" },
                new() { Name = "Searches", Icon = Resources.Searches, SettingsKey = "CategoriesToExportSearches" },
                new() { Name = "Notes", Icon = Resources.Notes, SettingsKey = "CategoriesToExportNotes" },
                new() { Name = "Wireless Networks", Icon = Resources.Wireless_Networks, SettingsKey = "CategoriesToExportWirelessNetworks" },
                new() { Name = "Notifications", Icon = Resources.Notifications, SettingsKey = "CategoriesToExportNotifications" },
                new() { Name = "Locations", Icon = Resources.Locations, SettingsKey = "CategoriesToExportLocations" },
                new() { Name = "Cookies", Icon = Resources.Cookies, SettingsKey = "CategoriesToExportCookies" },
                new() { Name = "Configuration", Icon = Resources.Configuration, SettingsKey = "CategoriesToExportConfiguration" },
                new() { Name = "Passwords", Icon = Resources.Passwords, SettingsKey = "CategoriesToExportPasswords" },
                new() { Name = "Autofill", Icon = Resources.Autofill, SettingsKey = "CategoriesToExportAutofill" },
                new() { Name = "Cell Towers", Icon = Resources.Cell_Towers, SettingsKey = "CategoriesToExportCellTowers" },
                new() { Name = "Power Events", Icon = Resources.Power_Events, SettingsKey = "CategoriesToExportPowerEvents" },
                new() { Name = "User Dictionaries", Icon = Resources.User_Dictionaries, SettingsKey = "CategoriesToExportUserDictionaries" },
                new() { Name = "IP Connections", Icon = Resources.IP_Connections, SettingsKey = "CategoriesToExportIPConnections" },
                new() { Name = "Recordings", Icon = Resources.Recordings, SettingsKey = "CategoriesToExportRecordings" },
                new() { Name = "Mobile Cards", Icon = Resources.Mobile_Cards, SettingsKey = "CategoriesToExportMobileCards" },
                new() { Name = "Applications Usage", Icon = Resources.Applications_Usage, SettingsKey = "CategoriesToExportApplicationsUsage" },
                new() { Name = "Device Information", Icon = Resources.Device_Information, SettingsKey = "CategoriesToExportDeviceInformation" },
                new() { Name = "Activities Sensor", Icon = Resources.Activities_Sensor, SettingsKey = "CategoriesToExportActivitiesSensor" },
                new() { Name = "Credit Cards", Icon = Resources.Credit_Cards, SettingsKey = "CategoriesToExportCreditCards" },
                new() { Name = "Device Connectivity", Icon = Resources.Device_Connectivity, SettingsKey = "CategoriesToExportDeviceConnectivity" },
                new() { Name = "Device Events", Icon = Resources.Device_Events, SettingsKey = "CategoriesToExportDeviceEvents" },
                new() { Name = "File Downloads", Icon = Resources.File_Downloads, SettingsKey = "CategoriesToExportFileDownloads" },
                new() { Name = "Journeys", Icon = Resources.Journeys, SettingsKey = "CategoriesToExportJourneys" },
                new() { Name = "Networks Usage", Icon = Resources.Networks_Usage, SettingsKey = "CategoriesToExportNetworksUsage" },
                new() { Name = "Recognized Devices", Icon = Resources.Recognized_Devices, SettingsKey = "CategoriesToExportRecognizedDevices" },
                new() { Name = "Social Media Activities", Icon = Resources.Social_Media_Activities, SettingsKey = "CategoriesToExportSocialMediaActivities" },
            }
        };

        public string? Name { get; set; }
        public Bitmap? Icon { get; set; }
        public string? SettingsKey { get; set; }
        public List<Category>? SubCategories { get; set; }

    }
}
