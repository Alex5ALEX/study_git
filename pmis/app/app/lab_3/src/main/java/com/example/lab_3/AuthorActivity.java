package com.example.lab_3;

import static androidx.core.content.ContextCompat.startActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.CheckBox;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

public class AuthorActivity extends AppCompatActivity {

    private CheckBox checkboxSecret;
    private MenuItem secretMenuItem;
    private Menu menu2;

    @SuppressLint("MissingSuperCall")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.author_activity);



        checkboxSecret = findViewById(R.id.checkbox_secret);
        checkboxSecret.setOnCheckedChangeListener((buttonView, isChecked) -> {
            // Обновляем видимость элемента меню при изменении состояния CheckBox
            secretMenuItem = menu2.findItem(3);
            if (secretMenuItem != null) {
                secretMenuItem.setVisible(isChecked);
            }
        });

    }

    //@Override
    public boolean onCreateOptionsMenu(Menu menu2) {
        this.menu2 = menu2;

        menu2.add(0, 1, 0, "Back");
        menu2.add(0, 2, 0, "Exit");
        menu2.add(0, 3, 0, "Secret");
        menu2.findItem(3).setVisible(false);
        return super.onCreateOptionsMenu(menu2);
    }

    //@Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == 1) {
            Intent intent = new Intent(this, MainActivity.class);
            startActivity(intent);
            return true;
        } else if (item.getItemId() == 2) {
            finishAffinity();
            return true;
        } else if (item.getItemId() == 3) {
            //Toast.makeText(AuthorActivity.this, "SECRET", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(this, SecretActivity.class);
            startActivity(intent);
            return true;
        }
        return super.onOptionsItemSelected(item);
    }




}
