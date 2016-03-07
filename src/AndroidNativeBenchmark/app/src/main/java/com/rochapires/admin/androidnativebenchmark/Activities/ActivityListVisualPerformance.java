package com.rochapires.admin.androidnativebenchmark.Activities;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ListView;

import com.rochapires.admin.androidnativebenchmark.R;


public class ActivityListVisualPerformance extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_activity_list_visual_performance);

        ListView listView = (ListView)findViewById(R.id.listView);
        listView.setAdapter(new CustomAdapter(this));
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_activity_visual_performance, menu);
        return true;
    }

}
