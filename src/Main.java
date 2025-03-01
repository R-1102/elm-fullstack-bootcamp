import java.util.*;
//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.

public class Main {
    public static void main(String[] args) {

        List<Product> products = new ArrayList<>();

        products.add(new Electronics(1, "Dell XPS 13", 1200, 10));
        products.add(new Electronics(2, "MacBook Pro 16", 2500, 5));
        products.add(new Electronics(3, "Samsung Galaxy S23", 999, 15));
        products.add(new Footwear(4, "Nike Air Max", 150, 20, "42"));
        products.add(new Footwear(5, "Adidas Ultraboost", 180, 12, "44"));
        products.add(new Electronics(6, "Sony PlayStation 5", 499, 8));
        products.add(new Clothing(7, "Nike T-Shirt", 50, 20, "M"));
        products.add(new Clothing(8, "Adidas Sneakers", 120, 15, "42"));

        // Orders Storage
        List<Order> orders = new ArrayList<>();
        HashMap<Integer, Order> userOrderHistory = new HashMap<>();

        // CLI
        Scanner scanner = new Scanner(System.in);
        boolean running = true;

        while (running) {
            System.out.println("\n===== Menu =====");
            System.out.println("1. Place an order");
            System.out.println("2. View order history");
            System.out.println("3. Exit");
            System.out.print("Choose an option: ");
            int choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    // Place an order
                    System.out.print("Enter your user ID: ");
                    int userID = scanner.nextInt();

                    System.out.println("Available Products:");
                    for (Product product : products) {
                        System.out.println(product.id + ". " + product.name + " - Price: " + product.price + ", Stock: " + product.stockQuantity);
                    }

                    System.out.print("Enter the product ID you want to buy: ");
                    int productID = scanner.nextInt();

                    System.out.print("Enter the quantity you want to buy: ");
                    int quantity = scanner.nextInt();

                    // Check if the product ID is valid
                    if (productID > products.size() || productID <= 0) {
                        System.out.println("Invalid product ID!");
                        break;
                    }

                    Product selectedProduct = products.get(productID - 1);

                    // Place the order and reduce stock
                    try {
                        Order order = new Order(userID, orders.size() + 1);
                        selectedProduct.reduceStock(quantity);
                        order.addOrderDetail(new OrderDetails(order.orderID, userID, productID, quantity, selectedProduct.price * quantity));

                        orders.add(order);
                        userOrderHistory.put(userID, order);

                        System.out.println("Order placed: " + order);
                    } catch (OutOfStockException e) {
                        System.out.println(e.getMessage());
                    }
                    break;

                case 2:
                    // View order history
                    System.out.print("Enter your user ID to view order history: ");
                    int userHistoryID = scanner.nextInt();

                    if (userOrderHistory.containsKey(userHistoryID)) {
                        System.out.println("\nOrder History for User ID " + userHistoryID + ":");
                        System.out.println(userOrderHistory.get(userHistoryID));
                    } else {
                        System.out.println("No orders found for User ID " + userHistoryID);
                    }
                    break;

                case 3:
                    // Exit the program
                    System.out.println("Exiting... Goodbye!");
                    running = false;
                    break;

                default:
                    System.out.println("Invalid option. Please try again.");
            }
        }
        scanner.close();
    }
}