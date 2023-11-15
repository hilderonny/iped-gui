import PySimpleGUI as sg

def Win11Checkbox(key, label, description):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Text(text=description,text_color='#666666',size=(100,None)) ]
                    ]),
                    sg.Push(),
                    sg.Checkbox(text='',key=key,enable_events=True,default=sg.user_settings_get_entry(key, False))
                ]
            ]
        )
    ]

def Win11Combo(key, label, description, values, default_value):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Text(text=description,text_color='#666666',size=(80,None)) ]
                    ]),
                    sg.Push(),
                    sg.Combo(key=key,values=values,enable_events=True,default_value=sg.user_settings_get_entry(key, default_value))
                ]
            ]
        )
    ]

def Win11FileChooser(key, label, description):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Input(key=key,default_text=sg.user_settings_get_entry(key, ''),expand_x=True,readonly=True,enable_events=True)],
                        [ sg.Text(text=description,text_color='#666666',size=(80,None)) ]
                    ]),
                    sg.Push(),
                    sg.FileBrowse(button_text='Select file ...',target=key)
                ]
            ]
        )
    ]

def Win11FolderChooser(key, label, description):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Input(key=key,default_text=sg.user_settings_get_entry(key, ''),expand_x=True,readonly=True,enable_events=True)],
                        [ sg.Text(text=description,text_color='#666666',size=(80,None)) ]
                    ]),
                    sg.Push(),
                    sg.FolderBrowse(button_text='Select folder ...',target=key)
                ]
            ]
        )
    ]

def Win11Input(key, label, description, width=None):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Text(text=description,text_color='#666666',size=(100,None)) ]
                    ]),
                    sg.Push(),
                    sg.Input(key=key,enable_events=True,default_text=sg.user_settings_get_entry(key,''),size=(width,None))
                ]
            ]
        )
    ]
