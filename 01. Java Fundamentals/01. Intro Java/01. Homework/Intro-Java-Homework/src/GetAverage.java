import java.util.Scanner;

public class GetAverage {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		float num1 = scan.nextFloat();
		float num2 = scan.nextFloat();
		float num3 = scan.nextFloat();
		scan.close();
		
		System.out.println(String.format("%.2f", average(num1, num2, num3)));
	}
	public static float average(float fl1, float fl2, float fl3){
		return ((fl1+fl2+fl3)/3);
	}
}
