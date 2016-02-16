package com.rochapires.admin.androidnativebenchmark.Activities;

import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.rochapires.admin.androidnativebenchmark.R;

/**
 * Created by admin on 21/06/2015.
 */
public class CustomAdapter extends BaseAdapter {

    ActivityListVisualPerformance activity;
    private static int NUMBER_OF_ROWS = 50;

    public CustomAdapter(ActivityListVisualPerformance activity) {
        this.activity = activity;
    }

    @Override
    public int getCount() {
        return NUMBER_OF_ROWS;
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        View view;// = convertView != null ? activity.getLayoutInflater().inflate(R.layout.listItem, parent, false);

        if(convertView!= null) {
            view = convertView;
        } else {
            view = activity.getLayoutInflater().inflate(R.layout.list_item, parent, false);
        }

        TextView textView = (TextView)view.findViewById(R.id.textView);
        ImageView imageView = (ImageView)view.findViewById(R.id.imageView);
        textView.setText("elebleriii");

        imageView.setImageResource(R.drawable.profilepic);

        return view;
    }

}
