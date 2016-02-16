package com.rochapires.admin.androidnativebenchmark.Activities;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;

import com.rochapires.admin.androidnativebenchmark.R;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    public void startActivityAlgorithmPerformance(View view) {
        Intent intent = new Intent(this, ActivityAlgorithmPerformance.class);
        startActivity(intent);
    }

    public void startActivityListVisualPerformance(View view) {
        Intent intent = new Intent(this, ActivityListVisualPerformance.class);
        startActivity(intent);
    }

    public void startActivityControlsVisualPerformance(View view) {
        Intent intent = new Intent(this, ActivityControlsVisualPerformance.class);
        startActivity(intent);
    }

    public void startActivityMemoryTest(View view) {
        Intent intent = new Intent(this, ActivityMemoryTest.class);
        startActivity(intent);
    }

    public void startActivityCameraAccess(View view) {
        //Intent intent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);

        //fileUri = getOutputMediaFileUri(MEDIA_TYPE_IMAGE); // create a file to save the image
        //intent.putExtra(MediaStore.EXTRA_OUTPUT, fileUri); // set the image file name

        // start the image capture Intent
        //startActivityForResult(intent, CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE);

        Intent intent = new Intent(this, ActivityCameraAccess.class);
        startActivity(intent);
    }
}
