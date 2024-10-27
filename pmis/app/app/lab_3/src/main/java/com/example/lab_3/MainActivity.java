package com.example.lab_3;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        TextView text = (TextView)findViewById(R.id.textView);
        text.setText(getResources().getText(R.string.text));



        Button btn_red = (Button)findViewById(R.id.button1);
        Button btn_green = (Button)findViewById(R.id.button2);
        Button btn_blue = (Button)findViewById(R.id.button3);
        Button btn_message = (Button)findViewById(R.id.button4);

        btn_red.setBackgroundColor(getResources().getColor(R.color.red));
        btn_green.setBackgroundColor(getResources().getColor(R.color.green));
        btn_blue.setBackgroundColor(getResources().getColor(R.color.blue));
        btn_message.setBackgroundColor(getResources().getColor(R.color.black));

        btn_red.setText(getResources().getText(R.string.red_button));
        btn_green.setText(getResources().getText(R.string.green_button));
        btn_blue.setText(getResources().getText(R.string.blue_button));
        btn_message.setText(getResources().getText(R.string.message_button));



        btn_red.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                text.setTextColor(getResources().getColor(R.color.red));
            }
        });

        btn_green.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                text.setTextColor(getResources().getColor(R.color.green));
            }
        });

        btn_blue.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                text.setTextColor(getResources().getColor(R.color.blue));
            }
        });

        btn_message.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(MainActivity.this, getResources().getText(R.string.push_text), Toast.LENGTH_SHORT).show();
            }
        });

    }
}