package heesuekim.a20170509_lecturedemo;

import android.graphics.Color;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;
import java.lang.Object;

public class MainActivity extends AppCompatActivity {
    //program package
    //should have pre-defined initiation method

    @Override
    protected void onCreate(Bundle savedInstanceState) {

            myLocalTV.setText("Light OK.");
        }
    }

}
