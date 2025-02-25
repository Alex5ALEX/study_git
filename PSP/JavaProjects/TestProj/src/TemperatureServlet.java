import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/temperature")
public class TemperatureServlet extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String filename = getServletContext().getRealPath("/data/temperature.txt");
        TemperatureData data = new TemperatureData(filename);

        double average = data.getAverageTemperature();
        long daysAboveAverage = data.countDaysAboveAverage();
        long daysBelowZero = data.countDaysBelowZero();
        List<Double> topThreeWarmest = data.getTopThreeWarmestDays();

        request.setAttribute("average", average);
        request.setAttribute("daysAboveAverage", daysAboveAverage);
        request.setAttribute("daysBelowZero", daysBelowZero);
        request.setAttribute("topThreeWarmest", topThreeWarmest);

        request.getRequestDispatcher("result.jsp").forward(request, response);
    }
}