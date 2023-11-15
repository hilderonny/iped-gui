import PySimpleGUI as sg
import modules.win11widgets as w11

def createAnalysisTab():
    return sg.Tab(title='Analysis', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                w11.Win11Combo(key='locale',label='Program language',description="Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'",values=['en', 'pt-BR', 'it-IT', 'de-DE', 'es-AR'],default_value='de-DE'),
                w11.Win11FolderChooser(key='indexTemp',label='Temporary directory for processing',description='Configure it on a folder free of antivirus, system indexing or restoring. Using a SSD disk is highly recommended.'),
                w11.Win11Checkbox(key='indexTempOnSSD', label='Temporary directory is on SSD', description='Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you will have performance problems.'),
                w11.Win11Checkbox(key='outputOnSSD', label='Output directory is on SSD', description='Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp folder.'),
                w11.Win11Input(key='numThreads',label='Number of processing threads/workers',description='"default" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms).',width=8),
                w11.Win11FileChooser(key='hashesDB',label='Hash database',description='Full path for IPED hash database. It is highly recommended to store it on a fast disk, preferably SSD, and not the same used as "indexTemp", if other disk is available.'),
                w11.Win11FolderChooser(key='pluginFolder',label='Plugin folder',description='Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime.'),
            ]),
        ],
    ])

def createConfigTab():
    return sg.Tab(title='Configuration', layout=[
        [
            sg.TabGroup(expand_x=True, expand_y=True, layout=[
                [
                    createAnalysisTab(),
                ]
            ])
        ],
    ])
