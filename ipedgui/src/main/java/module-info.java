module com.tlka.ipedgui {
    requires javafx.controls;
    requires javafx.fxml;

    opens com.tlka.ipedgui to javafx.fxml;
    exports com.tlka.ipedgui;
}
