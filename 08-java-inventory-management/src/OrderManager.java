import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class OrderManager {
    private ExecutorService executor = Executors.newFixedThreadPool(10);
    public OrderManager() {
        System.out.print("Here is order branch");
    }

    public void processOrder(Order order) {
        executor.submit(() -> {
            try {
                // Simulating processing time
                Thread.sleep(2000);
                order.setOrderStatus(Order.OrderStatus.SHIPPED);
                logOrderUpdate(order);

                // Simulate further processing
                Thread.sleep(2000);
                order.setOrderStatus(Order.OrderStatus.DELIVERED);
                logOrderUpdate(order);
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
        });
    }

    private void logOrderUpdate(Order order) {
        System.out.println("Order ID: " + order.getOrderId() + " Status: " + order.getOrderStatus());
    }
}
