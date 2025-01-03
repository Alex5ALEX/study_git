package com.example.lab_3;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

public class ResultActivity extends AppCompatActivity {

    int color;

    @SuppressLint({"MissingSuperCall", "MissingInflatedId"})
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.result_actitivity);


        //color = getResources().getColor(R.color.white);

        color = (int) getIntent().getExtras().get("color");

        TextView text = (TextView)findViewById(R.id.resultView);

        text.setText(getResources().getText(R.string.result_text));
        text.setTextColor(color);
    }


    //    @Override
    public boolean onCreateOptionsMenu(Menu menu2) {
        menu2.add(0, 1, 0, "Back");
        menu2.add(0, 2, 0, "Exit");
        return super.onCreateOptionsMenu(menu2);
    }

    //    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == 1) {
            Intent intent = new Intent(this, MainActivity.class);
            startActivity(intent);
            return true;
        } else if (item.getItemId() == 2) {
            finishAffinity();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
