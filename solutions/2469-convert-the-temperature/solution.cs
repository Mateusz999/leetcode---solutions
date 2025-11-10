public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double[] tempCon = new double[2];
        tempCon[0] = celsius + 273.15;
        tempCon[1] = celsius * 1.80 + 32.00;
        return tempCon;
    }
}