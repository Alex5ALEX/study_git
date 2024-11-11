package com.example.lab_3;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

public class ResultActivity extends AppCompatActivity {


    @SuppressLint("MissingSuperCall")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.result_actitivity);


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
