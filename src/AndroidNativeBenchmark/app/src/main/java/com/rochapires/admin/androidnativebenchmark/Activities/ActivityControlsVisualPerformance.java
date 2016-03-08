package com.rochapires.admin.androidnativebenchmark.Activities;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.ListView;

import com.rochapires.admin.androidnativebenchmark.R;


public class ActivityControlsVisualPerformance extends AppCompatActivity implements View.OnClickListener {

    private long timeElapsed;
    private long startTime;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_activity_controls_visual_performance);

        LinearLayout linearLayoutWrapper = (LinearLayout) findViewById(R.id.linearLayout_wrapper);

        startTime = System.currentTimeMillis();
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
                button.setOnClickListener(this);
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

    @Override
    public void onWindowFocusChanged(boolean hasFocus) {
        super.onWindowFocusChanged(hasFocus);
        if(this.timeElapsed == 0){
            this.timeElapsed = System.currentTimeMillis() - startTime;
        }
    }

    @Override
    public void onClick(View view) {
        new AlertDialog.Builder(this)
                .setTitle("Time elapsed")
                .setMessage(timeElapsed + " miliseconds")
                .setNeutralButton("OK", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {

                    }
                })
                .show();
    }
}
