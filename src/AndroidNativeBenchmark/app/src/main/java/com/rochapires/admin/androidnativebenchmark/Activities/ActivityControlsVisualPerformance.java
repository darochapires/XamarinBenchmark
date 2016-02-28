package com.rochapires.admin.androidnativebenchmark.Activities;

import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.ListView;

import com.rochapires.admin.androidnativebenchmark.R;


public class ActivityControlsVisualPerformance extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_activity_controls_visual_performance);

        LinearLayout linearLayoutWrapper = (LinearLayout) findViewById(R.id.linearLayout_wrapper);

        //TODO: test Out of memory
        for (int j = 0; j < 450; j++)
        {
            LinearLayout linearLayout = new LinearLayout(this);
            LinearLayout.LayoutParams linearLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, LinearLayout.LayoutParams.WRAP_CONTENT);
            linearLayout.setOrientation(LinearLayout.HORIZONTAL);
            linearLayoutWrapper.addView(linearLayout, linearLayoutParams);

            for (int i = 0; i < 20; i++)
            {
                Button button = new Button(this);
                button.setText("X");
                linearLayoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT);
                linearLayoutParams.weight = 1;
                linearLayout.addView(button, linearLayoutParams);
            }

        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_activity_visual_performance, menu);
        return true;
    }

}
