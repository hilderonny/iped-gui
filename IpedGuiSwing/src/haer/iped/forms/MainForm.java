package haer.iped.forms;

import haer.iped.helper.ConfigHelper;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultListModel;
import javax.swing.JFileChooser;

/**
 * Hauptfenster mit Tabs
 * @author Ronny Hildebrandt
 */
public class MainForm extends javax.swing.JFrame {

    public MainForm() {
        // Den Form-Editor lassen wir außen vor, weil die Tabs dynamisch ein-
        // und ausgeblendet werden sollen
        initComponents();
        
        // Ausgangszustand der UI Elemente setzen
        tfAusgabeverzeichnis.setText(ConfigHelper.getOutputDirectory());
        cbProjektErweitern.setSelected(ConfigHelper.getAppend());
        cbFortsetzen.setSelected(ConfigHelper.getContinue());
        cbPortabel.setSelected(ConfigHelper.getPortable());
        cbInternetdatenLaden.setSelected(ConfigHelper.getDownloadInternetData());
        cbAudioTranslation.setSelected(ConfigHelper.getAudioTranslation());
        cbBildKlassifizierung.setSelected(ConfigHelper.getImageClassification());
        cbOcr.setSelected(ConfigHelper.getOcr());
                
        checkLblWarnung();
    }
    
    private List<String> selektierteSpuren = new ArrayList<>();

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblSpuren = new javax.swing.JLabel();
        spSpuren = new javax.swing.JScrollPane();
        lstSpuren = new javax.swing.JList(new javax.swing.DefaultListModel<String>());
        btnHinzufuegen = new javax.swing.JButton();
        btnLoeschen = new javax.swing.JButton();
        lblAusgabeverzeichnis = new javax.swing.JLabel();
        tfAusgabeverzeichnis = new javax.swing.JTextField();
        btnAuswaehlen = new javax.swing.JButton();
        cbProjektErweitern = new javax.swing.JCheckBox();
        cbFortsetzen = new javax.swing.JCheckBox();
        cbPortabel = new javax.swing.JCheckBox();
        cbInternetdatenLaden = new javax.swing.JCheckBox();
        btnStarten = new javax.swing.JButton();
        lblWarnung = new javax.swing.JLabel();
        spKonsole = new javax.swing.JScrollPane();
        taKonsole = new javax.swing.JTextArea();
        cbAudioTranslation = new javax.swing.JCheckBox();
        cbBildKlassifizierung = new javax.swing.JCheckBox();
        cbOcr = new javax.swing.JCheckBox();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        lblSpuren.setText("Spuren");

        lstSpuren.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                lstSpurenValueChanged(evt);
            }
        });
        spSpuren.setViewportView(lstSpuren);

        btnHinzufuegen.setText("Hinzufügen ...");
        btnHinzufuegen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnHinzufuegenActionPerformed(evt);
            }
        });

        btnLoeschen.setText("Löschen");
        btnLoeschen.setEnabled(false);
        btnLoeschen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLoeschenActionPerformed(evt);
            }
        });

        lblAusgabeverzeichnis.setText("Ausgabeverzeichnis");

        tfAusgabeverzeichnis.setEditable(false);

        btnAuswaehlen.setText("Auswählen ...");
        btnAuswaehlen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAuswaehlenActionPerformed(evt);
            }
        });

        cbProjektErweitern.setText("Bestehendes Projekt erweitern");
        cbProjektErweitern.setToolTipText("Wenn in dem Ausgabeverzeichnis bereits ein Projekt vorhanden ist, können dem Projekt mit dieser Option neue Spuren hinzugefügt werden.");
        cbProjektErweitern.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbProjektErweiternActionPerformed(evt);
            }
        });

        cbFortsetzen.setText("Nach Abbruch fortsetzen");
        cbFortsetzen.setToolTipText("Wenn IPED vormals abgestürzt ist, kann mit dieser Option ein vorheriger Einleseprozess fortgesetzt werden. Dazu müssen allerdings dieselben Spuren zum Einlesen ausgewählt werden.");
        cbFortsetzen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbFortsetzenActionPerformed(evt);
            }
        });

        cbPortabel.setText("Portabel");
        cbPortabel.setToolTipText("Hiermit werden die Dateien der Spuren in das Ausgabeverzeichnis kopiert und somit unabhängig von der Quelle.");
        cbPortabel.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbPortabelActionPerformed(evt);
            }
        });

        cbInternetdatenLaden.setText("Internetdaten laden");
        cbInternetdatenLaden.setToolTipText("Hiermit werden bei Bedarf Daten aus den Netz geladen. Das können z.B. in Chats verlinkte Anhänge sein.");
        cbInternetdatenLaden.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbInternetdatenLadenActionPerformed(evt);
            }
        });

        btnStarten.setText("Starten");
        btnStarten.setEnabled(false);
        btnStarten.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnStartenActionPerformed(evt);
            }
        });

        lblWarnung.setForeground(new java.awt.Color(255, 0, 0));

        taKonsole.setColumns(20);
        taKonsole.setLineWrap(true);
        taKonsole.setRows(5);
        taKonsole.setWrapStyleWord(true);
        spKonsole.setViewportView(taKonsole);

        cbAudioTranslation.setText("Audio Transkription und Übersetzung");
        cbAudioTranslation.setToolTipText("Für diese Funktion muss der Hintergrundprozess für die Audioverarbeitung laufen");
        cbAudioTranslation.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbAudioTranslationActionPerformed(evt);
            }
        });

        cbBildKlassifizierung.setText("Bilder klassifizieren");
        cbBildKlassifizierung.setToolTipText("Für diese Funktion muss der Hintergrundprozess für die Bildklassifizierung laufen");
        cbBildKlassifizierung.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbBildKlassifizierungActionPerformed(evt);
            }
        });

        cbOcr.setText("Texterkennung in Bildern und PDFs per OCR");
        cbOcr.setToolTipText("Das kann den Vorgang bei vielen Bildern stark verlängern");
        cbOcr.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbOcrActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addComponent(lblAusgabeverzeichnis, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblSpuren, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(cbInternetdatenLaden, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(cbPortabel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(cbFortsetzen, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(cbProjektErweitern, javax.swing.GroupLayout.DEFAULT_SIZE, 262, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(cbOcr, javax.swing.GroupLayout.DEFAULT_SIZE, 285, Short.MAX_VALUE)
                            .addComponent(cbBildKlassifizierung, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(cbAudioTranslation, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblWarnung, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(spSpuren, javax.swing.GroupLayout.DEFAULT_SIZE, 732, Short.MAX_VALUE)
                            .addComponent(tfAusgabeverzeichnis)
                            .addComponent(spKonsole))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnStarten, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnLoeschen, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btnHinzufuegen, javax.swing.GroupLayout.DEFAULT_SIZE, 119, Short.MAX_VALUE)
                            .addComponent(btnAuswaehlen, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btnHinzufuegen)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnLoeschen))
                    .addComponent(spSpuren, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblSpuren))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(tfAusgabeverzeichnis, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblAusgabeverzeichnis)
                    .addComponent(btnAuswaehlen))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblWarnung, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(cbProjektErweitern)
                            .addComponent(cbAudioTranslation))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(cbFortsetzen)
                            .addComponent(cbBildKlassifizierung))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(cbPortabel)
                            .addComponent(cbOcr))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(cbInternetdatenLaden)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(spKonsole, javax.swing.GroupLayout.DEFAULT_SIZE, 207, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(btnStarten)))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnHinzufuegenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnHinzufuegenActionPerformed
        JFileChooser fileChooser = new JFileChooser();
        fileChooser.setFileSelectionMode(JFileChooser.FILES_AND_DIRECTORIES);
        fileChooser.setMultiSelectionEnabled(true);
        fileChooser.setCurrentDirectory(new File(ConfigHelper.getInputDirectory()));
        int result = fileChooser.showDialog(null, "Hinzufügen");
        try {
            ConfigHelper.setInputDirectory(fileChooser.getCurrentDirectory().getPath());
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
        if (result == JFileChooser.APPROVE_OPTION) {
            DefaultListModel<String> model = (DefaultListModel<String>) lstSpuren.getModel();
            for (File f : fileChooser.getSelectedFiles()) {
                String filePath = f.getAbsolutePath();
                if (!model.contains(filePath)) {
                    model.addElement(filePath);
                }
            }
            checkLblWarnung();
            checkBtnStarten();
        }
    }//GEN-LAST:event_btnHinzufuegenActionPerformed

    private void btnAuswaehlenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAuswaehlenActionPerformed
        JFileChooser folderChooser = new JFileChooser();
        folderChooser.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
        folderChooser.setMultiSelectionEnabled(false);
        int result = folderChooser.showDialog(null, "Auswählen");
        if (result == JFileChooser.APPROVE_OPTION) {
            String folderPath = folderChooser.getSelectedFile().getAbsolutePath();
            tfAusgabeverzeichnis.setText(folderPath);
            try {
                ConfigHelper.setOutputDirectory(folderPath);
            } catch (IOException ex) {
                Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
            }
            checkLblWarnung();
            checkBtnStarten();
        }
    }//GEN-LAST:event_btnAuswaehlenActionPerformed

    private void cbProjektErweiternActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbProjektErweiternActionPerformed
        boolean isSelected = cbProjektErweitern.isSelected();
        try {
            if (isSelected) { 
                cbFortsetzen.setSelected(false);
                ConfigHelper.setContinue(false);
            }
            ConfigHelper.setAppend(isSelected);
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
        checkLblWarnung();
    }//GEN-LAST:event_cbProjektErweiternActionPerformed

    private void cbFortsetzenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbFortsetzenActionPerformed
        boolean isSelected = cbFortsetzen.isSelected();
        try {
            if (isSelected) {
                cbProjektErweitern.setSelected(false);
                ConfigHelper.setAppend(false);
            }
            ConfigHelper.setContinue(isSelected);
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
        checkLblWarnung();
    }//GEN-LAST:event_cbFortsetzenActionPerformed

    private void lstSpurenValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_lstSpurenValueChanged
        selektierteSpuren = lstSpuren.getSelectedValuesList();
        if (selektierteSpuren.isEmpty()) {
            btnLoeschen.setEnabled(false);
        } else {
            btnLoeschen.setEnabled(true);
        }
    }//GEN-LAST:event_lstSpurenValueChanged

    private void btnLoeschenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLoeschenActionPerformed
        DefaultListModel<String> model = (DefaultListModel<String>) lstSpuren.getModel();
        for (String spurPath : selektierteSpuren) {
            model.removeElement(spurPath);
        }
        btnLoeschen.setEnabled(false);
        checkLblWarnung();
        checkBtnStarten();
    }//GEN-LAST:event_btnLoeschenActionPerformed

    private void btnStartenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnStartenActionPerformed
        ArrayList<String> commandParts = new ArrayList<>();
        commandParts.add(".\\iped.exe");
        if (cbFortsetzen.isSelected()) {
            commandParts.add("--continue");
        }
        if (cbInternetdatenLaden.isSelected()) {
            commandParts.add("--downloadInternetData");
        }
        if (cbPortabel.isSelected()) {
            commandParts.add("--portable");
        }
        if (cbProjektErweitern.isSelected()) {
            commandParts.add("--append");
        }
        ((DefaultListModel<String>)lstSpuren.getModel()).elements().asIterator().forEachRemaining(spur -> {
            commandParts.add("-d");
            commandParts.add("\"" + spur + "\"");
        });
        commandParts.add("-o");
        commandParts.add("\"" + tfAusgabeverzeichnis.getText() + "\"");
        try {
            ConfigHelper.saveOcrConfig();
            ConfigHelper.saveIpedConfig();
            startProcess(commandParts);
        } catch (IOException ex) {
            logLine(ex.toString());
        }
    }//GEN-LAST:event_btnStartenActionPerformed

    private void cbPortabelActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbPortabelActionPerformed
        try {
            ConfigHelper.setPortable(cbPortabel.isSelected());
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_cbPortabelActionPerformed

    private void cbInternetdatenLadenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbInternetdatenLadenActionPerformed
        try {
            ConfigHelper.setDownloadInternetData(cbInternetdatenLaden.isSelected());
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_cbInternetdatenLadenActionPerformed

    private void cbAudioTranslationActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbAudioTranslationActionPerformed
        try {
            ConfigHelper.setAudioTranslation(cbAudioTranslation.isSelected());
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_cbAudioTranslationActionPerformed

    private void cbBildKlassifizierungActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbBildKlassifizierungActionPerformed
        try {
            ConfigHelper.setImageClassification(cbBildKlassifizierung.isSelected());
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_cbBildKlassifizierungActionPerformed

    private void cbOcrActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbOcrActionPerformed
        try {
            ConfigHelper.setOcr(cbOcr.isSelected());
        } catch (IOException ex) {
            Logger.getLogger(MainForm.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_cbOcrActionPerformed

    private void logLine(String text) {
        taKonsole.append(text + "\n");
    }
    
    private void startProcess(ArrayList<String> commandParts) throws IOException {
        logLine(String.join(" ", commandParts));
        btnStarten.setEnabled(false);
        // https://stackoverflow.com/a/57949752
        ProcessBuilder pb = new ProcessBuilder(commandParts);
        pb.redirectErrorStream(true);
        Process process = pb.start();
        Thread commandLineThread = new Thread(() -> {
            try (BufferedReader in = new BufferedReader(new InputStreamReader(process.getInputStream())))
            {
                while (true)
                {
                    String line = in.readLine();
                    if (line == null) {
                        break;
                    }
                    logLine(line);
                }
            } catch (IOException ex) {
                logLine(ex.toString());
            }
            checkLblWarnung();
            btnStarten.setEnabled(true);
        });
        commandLineThread.setDaemon(true);
        commandLineThread.start();
    }
    
    private void checkBtnStarten() {
        boolean spurenSindVorhanden = lstSpuren.getModel().getSize() > 0;
        boolean ausgabeverzeichnisIstGesetzt = tfAusgabeverzeichnis.getText().length() > 0;
        if (spurenSindVorhanden && ausgabeverzeichnisIstGesetzt) { 
            btnStarten.setEnabled(true);
        } else {
            btnStarten.setEnabled(false);
        }
    }
    
    private void checkLblWarnung() {
        String folderPathText = tfAusgabeverzeichnis.getText();
        if (folderPathText.length() == 0) {
            lblWarnung.setText("");
        } else {
            try {
                Path folderPath = Paths.get(folderPathText);
                boolean directoryHasFiles = Files.list(folderPath).findAny().isPresent();
                if (directoryHasFiles) {
                    boolean isErweitern = cbProjektErweitern.isSelected();
                    boolean isFortsetzen = cbFortsetzen.isSelected();
                    if (!isErweitern && !isFortsetzen) {
                        lblWarnung.setText("<html>Das Ausgabeverzeichnis ist nicht leer. Soll das bestehende Projekt erweitert oder ein vorher abgebrochener Vorgang fortgesetzt werden?</html>");
                    } else {
                        lblWarnung.setText("");
                    }
                }
            } catch (IOException ex) {
                // Selektiertes Verzeichnis ist (nicht mehr) lesbar
                tfAusgabeverzeichnis.setText("");
                lblWarnung.setText("<html>Das Ausgabeverzeichnis ist nicht zugreifbar. Bitte wählen Sie ein anderes Verzeichnis.</html>");
            }
        }
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MainForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        ConfigHelper.load();
        
        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MainForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAuswaehlen;
    private javax.swing.JButton btnHinzufuegen;
    private javax.swing.JButton btnLoeschen;
    private javax.swing.JButton btnStarten;
    private javax.swing.JCheckBox cbAudioTranslation;
    private javax.swing.JCheckBox cbBildKlassifizierung;
    private javax.swing.JCheckBox cbFortsetzen;
    private javax.swing.JCheckBox cbInternetdatenLaden;
    private javax.swing.JCheckBox cbOcr;
    private javax.swing.JCheckBox cbPortabel;
    private javax.swing.JCheckBox cbProjektErweitern;
    private javax.swing.JLabel lblAusgabeverzeichnis;
    private javax.swing.JLabel lblSpuren;
    private javax.swing.JLabel lblWarnung;
    private javax.swing.JList<String> lstSpuren;
    private javax.swing.JScrollPane spKonsole;
    private javax.swing.JScrollPane spSpuren;
    private javax.swing.JTextArea taKonsole;
    private javax.swing.JTextField tfAusgabeverzeichnis;
    // End of variables declaration//GEN-END:variables
}
