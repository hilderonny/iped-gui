package haer.iped.helper;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Helper class for reading and storing configuration data.
 * Run load() for loading from disk and save() for saving to disk
 * @author Ronny
 */
public class ConfigHelper {
    
    private static final String PROPERTIES_FILE_PATH = "IpedGui.properties";
    private static final String PROPERTY_APPEND = "append";
    private static final String PROPERTY_CONTINUE = "continue";
    private static final String PROPERTY_DOWNLOADINTERNETDATA = "downloadInternetData";
    private static final String PROPERTY_OUTPUTDIRECTORY = "outputDirectory";
    private static final String PROPERTY_PORTABLE = "portable";

    private static Properties PROPERTIES;
    
    public static boolean getAppend() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_APPEND));
    }
    
    public static boolean getContinue() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_CONTINUE));
    }
    
    public static boolean getDownloadInternetData() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_DOWNLOADINTERNETDATA));
    }
    
    public static String getOutputDirectory() {
        return PROPERTIES.getProperty(PROPERTY_OUTPUTDIRECTORY);
    }
    
    public static boolean getPortable() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_PORTABLE));
    }
    
    public static void setAppend(boolean value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_APPEND, String.valueOf(value));
        save();
    }
    
    public static void setContinue(boolean value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_CONTINUE, String.valueOf(value));
        save();
    }
    
    public static void setDownloadInternetData(boolean value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_DOWNLOADINTERNETDATA, String.valueOf(value));
        save();
    }
    
    public static void setOutputDirectory(String value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_OUTPUTDIRECTORY, value);
        save();
    }
    
    public static void setPortable(boolean value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_PORTABLE, String.valueOf(value));
        save();
    }
    
    public static Properties load() {
        PROPERTIES = new Properties();
        try {
            PROPERTIES.load(new FileInputStream(PROPERTIES_FILE_PATH));
        } catch (IOException ex) {
            try {
                // Standardwerte festlegen
                setPortable(true);
                setDownloadInternetData(true);
            } catch (IOException ex1) {
                Logger.getLogger(ConfigHelper.class.getName()).log(Level.SEVERE, null, ex1);
            }
        }
        return PROPERTIES;
    }
    
    public static void save() throws IOException {
        PROPERTIES.store(new FileWriter(PROPERTIES_FILE_PATH), "");
    }
}
