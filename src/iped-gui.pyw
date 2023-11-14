PROGRAM_VERSION = '2.0.0'

import argparse
import PySimpleGUI as sg

sg.theme('SystemDefault1')

import modules.mainform as mainform

def handleConfigEvent(event, values):
    sg.user_settings_set_entry(event, values[event])

def main():
    # Parse command line arguments
    parser = argparse.ArgumentParser()
    parser.add_argument('--version', '-v', action='version', version=PROGRAM_VERSION)
    parser.parse_args()
    # Define config file
    sg.user_settings_filename('./config.json')
    # Create main window
    window = mainform.createmainform(PROGRAM_VERSION)

    # Main event loop
    while True:
        event, values = window.read()
        if event == sg.WIN_CLOSED:
            break
        else:
            handleConfigEvent(event, values)
    window.close()

if __name__ == '__main__':
    main()