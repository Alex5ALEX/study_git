package com.example.lab_1;

import android.os.Bundle;
import android.view.View;
import android.widget.Spinner;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.List;

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
    }

    public void onClickFindBeer(View view){
        BeerExpert expert = new BeerExpert();

        TextView brands = (TextView) findViewById(R.id.brands);

        Spinner spinner = (Spinner)  findViewById(R.id.color);

        String beerType = String.valueOf(spinner.getSelectedItem());


        List<String> recomendation =  expert.getBrands(beerType);
        String out = "";

        for (int i = 0; i < recomendation.size(); i++) {
            out += recomendation.get(i) + "\n";
            System.out.println(recomendation.get(i));
        }

        brands.setText(out);
    }
}