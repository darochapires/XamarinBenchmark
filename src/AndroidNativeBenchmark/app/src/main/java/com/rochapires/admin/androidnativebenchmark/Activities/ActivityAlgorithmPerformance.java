package com.rochapires.admin.androidnativebenchmark.Activities;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import com.rochapires.admin.androidnativebenchmark.R;


public class ActivityAlgorithmPerformance extends AppCompatActivity {

    private TextView textViewlTime1;
    private TextView textViewlTime2;
    private TextView textViewlTime3;
    private TextView textViewlTime4;
    private TextView textViewlTime5;
    private TextView textViewlTime6;
    private TextView textViewlTime7;
    private TextView textViewlTime8;
    private TextView textViewlTime9;
    private TextView textViewlTime10;
    private TextView textViewlTimeAverage;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_activity_algorithm_performance);

        textViewlTime1 = (TextView) findViewById(R.id.textViewlTime1);
        textViewlTime2 = (TextView) findViewById(R.id.textViewlTime2);
        textViewlTime3 = (TextView) findViewById(R.id.textViewlTime3);
        textViewlTime4 = (TextView) findViewById(R.id.textViewlTime4);
        textViewlTime5 = (TextView) findViewById(R.id.textViewlTime5);
        textViewlTime6 = (TextView) findViewById(R.id.textViewlTime6);
        textViewlTime7 = (TextView) findViewById(R.id.textViewlTime7);
        textViewlTime8 = (TextView) findViewById(R.id.textViewlTime8);
        textViewlTime9 = (TextView) findViewById(R.id.textViewlTime9);
        textViewlTime10 = (TextView) findViewById(R.id.textViewlTime10);
        textViewlTimeAverage = (TextView) findViewById(R.id.textViewlTimeAverage);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_activity_algorithm_performance, menu);
        return true;
    }

    public void RunFibonacci(View view)
    {
        runOnUiThread(new Runnable() {
            public void run() {
                TextView textViewlTime = (TextView) findViewById(R.id.textViewlTime1);
                EditText editTextNumberOfIterations = (EditText) findViewById(R.id.editTextNumberOfIterations);
                int numberOfIterations = Integer.parseInt(editTextNumberOfIterations.getText().toString());

                long startTime = System.currentTimeMillis();
                int result = Fibonacci(numberOfIterations);
                long timeElapsed = System.currentTimeMillis() - startTime;

                textViewlTime1.setText("Time " + ": " + timeElapsed);
                textViewlTime2.setText("");
                textViewlTime3.setText("");
                textViewlTime4.setText("");
                textViewlTime5.setText("");
                textViewlTime6.setText("");
                textViewlTime7.setText("");
                textViewlTime8.setText("");
                textViewlTime9.setText("");
                textViewlTime10.setText("");
                textViewlTimeAverage.setText("");
            }
        });
    }

    public void RunFibonacciTenTimes(View view)
    {
        runOnUiThread(new Runnable() {
            public void run() {

                EditText editTextNumberOfIterations = (EditText) findViewById(R.id.editTextNumberOfIterations);
                int numberOfIterations = Integer.parseInt(editTextNumberOfIterations.getText().toString());

                long totalTime = 0;
                for(int i = 1; i <= 10; i++) {
                    long startTime = System.currentTimeMillis();
                    int result = Fibonacci(numberOfIterations);
                    long timeElapsed = System.currentTimeMillis() - startTime;
                    totalTime += timeElapsed;
                    String timeElapsedText = "Time " + i + ": " + timeElapsed;
                    switch (i){
                        case 1:
                            textViewlTime1.setText(timeElapsedText);
                            break;
                        case 2:
                            textViewlTime2.setText(timeElapsedText);
                            break;
                        case 3:
                            textViewlTime3.setText(timeElapsedText);
                            break;
                        case 4:
                            textViewlTime4.setText(timeElapsedText);
                            break;
                        case 5:
                            textViewlTime5.setText(timeElapsedText);
                            break;
                        case 6:
                            textViewlTime6.setText(timeElapsedText);
                            break;
                        case 7:
                            textViewlTime7.setText(timeElapsedText);
                            break;
                        case 8:
                            textViewlTime8.setText(timeElapsedText);
                            break;
                        case 9:
                            textViewlTime9.setText(timeElapsedText);
                            break;
                        case 10:
                            textViewlTime10.setText(timeElapsedText);
                            break;
                        default:
                            break;
                    }
                }
                textViewlTimeAverage.setText("Average Time: " + totalTime / 10);
                Log.Info("AlgorithmPerformance", textViewlTimeAverage.Text);
            }
        });
    }

    public static int Fibonacci(int number)
    {
        if (number == 0) {
            return 0;
        } else if (number == 1) {
            return 1;
        } else
        {
            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }
    }

}
