package com.example.lab_1;

import java.util.ArrayList;
import java.util.List;


public class BeerExpert {
    public BeerExpert() {}

    List<String> getBrands(String color) {
        List<String> brands;
        brands = new ArrayList<>();
        if (color.equals("amber")) {
            brands.add("Jack Amber");
            brands.add("Red Moose");
        } else {
            brands.add("Jail Pale Ale");
            brands.add("Gout Stout");
        }
        return brands; }
}
