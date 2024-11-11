package com.example.lab_3;

import android.content.Intent;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.TextView;
import android.view.View;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    int color;
    TextView text;

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

        color = getResources().getColor(R.color.grey);

        text = (TextView)findViewById(R.id.textView);
        text.setText(getResources().getText(R.string.text));

        registerForContextMenu(text);


        Button btn_red = (Button)findViewById(R.id.button1);
        Button btn_green = (Button)findViewById(R.id.button2);
        Button btn_blue = (Button)findViewById(R.id.button3);
        Button btn_message = (Button)findViewById(R.id.button4);

        btn_red.setBackgroundColor(getResources().getColor(R.color.red));
        btn_green.setBackgroundColor(getResources().getColor(R.color.green));
        btn_blue.setBackgroundColor(getResources().getColor(R.color.blue));
        btn_message.setBackgroundColor(getResources().getColor(R.color.white));

        btn_red.setText(getResources().getText(R.string.red_button));
        btn_green.setText(getResources().getText(R.string.green_button));
        btn_blue.setText(getResources().getText(R.string.blue_button));
        btn_message.setText(getResources().getText(R.string.message_button));

        btn_red.setOnClickListener(this);
        btn_green.setOnClickListener(this);
        btn_blue.setOnClickListener(this);
        btn_message.setOnClickListener(this);

        /*
        btn_red.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                text.setTextColor(getResources().getColor(R.color.red));
            }
        });
        */

    }


    @Override
    public void onClick(View v){
        TextView text = (TextView)findViewById(R.id.textView);

        if(v.getId() == R.id.button1){
            color = getResources().getColor(R.color.red);
            text.setTextColor(color);
        }
        else if(v.getId() == R.id.button2){
            color = getResources().getColor(R.color.green);
            text.setTextColor(color);
        }
        else if(v.getId() == R.id.button3){
            color = getResources().getColor(R.color.blue);
            text.setTextColor(color);
        }
        else if(v.getId() == R.id.button4){
            Toast.makeText(MainActivity.this, getResources().getText(R.string.push_text), Toast.LENGTH_SHORT).show();
        }
    }

    //
    //сохранение состаяния при повороте экрана
    //

    //@Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        // Save the current text color as an integer
        int colortemp = text.getCurrentTextColor();
        outState.putInt("textKey", colortemp);
    }

    protected void onRestoreInstanceState(Bundle savedInstanceState) {
        super.onRestoreInstanceState(savedInstanceState);
        // Restore the text color
        int savedColor = savedInstanceState.getInt("textKey");
        text.setTextColor(savedColor);
    }



    //
    //выпадающее меню
    //
    //onprepareinstance
    @Override
    public boolean onCreateOptionsMenu(Menu menu){
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {

        if (item.getItemId() == R.id.Program) {
            //Toast.makeText(this, "You have clicked on About Program", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(this, ProgramActivity.class);
            startActivity(intent);
            return true;

        } else if (item.getItemId() == R.id.Author) {
            //Toast.makeText(this, "You have clicked on About Author", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(this, AuthorActivity.class);
            startActivity(intent);
            return true;

        } else if (item.getItemId() == R.id.Results) {
            //Toast.makeText(this, "You have clicked on Results", Toast.LENGTH_SHORT).show();
            Intent intent = new Intent(this, ResultActivity.class);
            intent.putExtra("color",color);
            startActivity(intent);
            return true;

        } else if (item.getItemId() == R.id.Exit) {
            finish();
            return true;
        } else {
            return super.onOptionsItemSelected(item);
        }
    }

    //
    //контекстное меню
    //

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.context_menu, menu);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == R.id.help) {
            Intent intent = new Intent(this, ProgramActivity.class);
            startActivity(intent);
            return true;
        } else if (item.getItemId() == R.id.no_help) {
            Toast.makeText(this, "Помощь не нужна", Toast.LENGTH_SHORT).show();
            return true;
        } else {
            return super.onContextItemSelected(item);
        }
    }


}