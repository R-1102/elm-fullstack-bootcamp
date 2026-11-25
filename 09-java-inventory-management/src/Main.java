import java.util.Scanner;

public class Main {
        public static void main(String[] args) {
                Scanner scanner = new Scanner(System.in);

                // Get the daily sales
                System.out.print("Enter average daily sales for Laptop: ");
                int laptopDailySales = scanner.nextInt();
                System.out.print("Enter average daily sales for Smartphone: ");
                int smartphoneDailySales = scanner.nextInt();

                // Creating products
                Product laptop = new Product("Laptop", 1200.0, 20, 5);
                Product smartphone = new Product("Smartphone", 800.0, 10, 3);

                // Display product details
                laptop.displayProductDetails();
                smartphone.displayProductDetails();

                // Predict stock depletion and suggest restocking
                StockPredictor.predictStockDepletion(laptop, laptopDailySales);
                StockPredictor.predictStockDepletion(smartphone, smartphoneDailySales);
        }
}

