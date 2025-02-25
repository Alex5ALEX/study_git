import java.io.*;
import java.util.*;

public class TemperatureData {
    private List<Double> temperatures;

    public TemperatureData(String filename) throws IOException {
        temperatures = new ArrayList<>();
        loadData(filename);
    }

    private void loadData(String filename) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader(filename));
        String line;
        while ((line = reader.readLine()) != null) {
            temperatures.add(Double.parseDouble(line));
        }
        reader.close();
    }

    public double getAverageTemperature() {
        return temperatures.stream().mapToDouble(Double::doubleValue).average().orElse(0);
    }

    public long countDaysAboveAverage() {
        double average = getAverageTemperature();
        return temperatures.stream().filter(temp -> temp > average).count();
    }

    public long countDaysBelowZero() {
        return temperatures.stream().filter(temp -> temp < 0).count();
    }

    public List<Double> getTopThreeWarmestDays() {
        return temperatures.stream()
                .sorted(Comparator.reverseOrder())
                .limit(3)
                .toList();
    }

    public List<Double> getTemperatures() {
        return temperatures;
    }
}
