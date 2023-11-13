PROGRAM_VERSION = '2.0.0'

import argparse
import PySimpleGUI

PySimpleGUI.theme('SystemDefault1')

import modules.mainform as mainform
import modules.config as cfg

def handleConfigEvent(event, values):
    section, parameter = event.split('-', 1)
    cfg.setConfig(section, parameter, values[event])

def main():
    # Parse command line arguments
    parser = argparse.ArgumentParser()
    parser.add_argument('--version', '-v', action='version', version=PROGRAM_VERSION)
    parser.parse_args()
    # Load config
    cfg.loadConfig()
    # Create main window
    window = mainform.createmainform(PROGRAM_VERSION)

    # Main event loop
    while True:
        event, values = window.read()
        if event == PySimpleGUI.WIN_CLOSED:
            break
        else:
            handleConfigEvent(event, values)
    window.close()

if __name__ == '__main__':
    main()