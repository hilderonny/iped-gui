package haer.iped.helper;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Helper class for reading and storing configuration data.
 * Run load() for loading from disk and save() for saving to disk
 * @author Ronny
 */
public class ConfigHelper {
    
    private static final String IPED_CONFIG_FILE_PATH = "IPEDConfig.txt";
    private static final String PROPERTIES_FILE_PATH = "IpedGui.properties";
    private static final String PROPERTY_APPEND = "append";
    private static final String PROPERTY_CONTINUE = "continue";
    private static final String PROPERTY_DOWNLOADINTERNETDATA = "downloadInternetData";
    private static final String PROPERTY_INPUTDIRECTORY = "inputDirectory";
    private static final String PROPERTY_IPED_AUDIOTRANSLATION = "iped_enableAudioTranslation";
    private static final String PROPERTY_IPED_IMAGECLASSIFICATION = "iped_enableImageClassification";
    private static final String PROPERTY_OUTPUTDIRECTORY = "outputDirectory";
    private static final String PROPERTY_PORTABLE = "portable";

    private static Properties PROPERTIES;
    
    public static boolean getAppend() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_APPEND));
    }
    
    public static boolean getAudioTranslation() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_IPED_AUDIOTRANSLATION));
    }
    
    public static boolean getContinue() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_CONTINUE));
    }
    
    public static boolean getDownloadInternetData() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_DOWNLOADINTERNETDATA));
    }
    
    public static boolean getImageClassification() {
        return Boolean.parseBoolean(PROPERTIES.getProperty(PROPERTY_IPED_IMAGECLASSIFICATION));
    }
    
    public static String getInputDirectory() {
        return PROPERTIES.getProperty(PROPERTY_INPUTDIRECTORY);
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
    
    public static void setAudioTranslation(boolean value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_IPED_AUDIOTRANSLATION, String.valueOf(value));
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
    
    public static void setImageClassification(boolean value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_IPED_IMAGECLASSIFICATION, String.valueOf(value));
        save();
    }
    
    public static void setInputDirectory(String value) throws IOException {
        PROPERTIES.setProperty(PROPERTY_INPUTDIRECTORY, value);
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
                setInputDirectory("./");
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
    
    public static void saveIpedConfig() throws IOException {
        ArrayList<String> configLines = new ArrayList<>();
        configLines.add("enableHash = true");
        configLines.add("enablePhotoDNA = false");
        configLines.add("enableHashDBLookup = true");
        configLines.add("enablePhotoDNALookup = false");
        configLines.add("enableLedDie = true");
        configLines.add("enableYahooNSFWDetection = false");
        configLines.add("enableQRCode = true");
        configLines.add("ignoreDuplicates = false");
        configLines.add("exportFileProps = false");
        configLines.add("processFileSignatures = true");
        configLines.add("enableFileParsing = true");
        configLines.add("expandContainers = true");
        configLines.add("processEmbeddedDisks = true");
        configLines.add("enableRegexSearch = true");
        configLines.add("enableAutomaticExportFiles = true");
        configLines.add("enableLanguageDetect = true");
        configLines.add("enableNamedEntityRecogniton = false");
        configLines.add("enableGraphGeneration = true");
        configLines.add("entropyTest = true");
        configLines.add("indexFileContents = true");
        configLines.add("enableIndexToElasticSearch = false");
        configLines.add("enableMinIO = false");
        configLines.add("enableAudioTranscription = false");
        configLines.add("enableCarving = true");
        configLines.add("enableLedCarving = false");
        configLines.add("enableKnownMetCarving = false");
        configLines.add("enableImageThumbs = true");
        configLines.add("enableImageSimilarity = true");
        configLines.add("enableFaceRecognition = true");
        configLines.add("enableVideoThumbs = true");
        configLines.add("enableDocThumbs = true");
        configLines.add("enableHTMLReport = true");
        configLines.add("enableAudioTranslation = " + String.valueOf(getAudioTranslation()));
        configLines.add("enableTextTranslation = false");
        configLines.add("enableImageClassification = " + String.valueOf(getImageClassification()));
        try (FileWriter fw = new FileWriter(IPED_CONFIG_FILE_PATH)) {
            fw.write(String.join("\n", configLines));
        }
    }
}
