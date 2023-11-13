import configparser

config = configparser.ConfigParser()

def loadConfig():
    global config
    config.read('config.ini')

def getConfig(section, parameter, default):
    global config
    if section in config:
        sec = config[section]
        if parameter in sec:
            return config[section][parameter]
    return default

def setConfig(section, parameter, value):
    global config
    if not section in config:
        config[section] = {}
    config[section][parameter] = str(value)
    saveConfig()

def saveConfig():
    global config
    with open('config.ini', 'w') as configfile:
        config.write(configfile)