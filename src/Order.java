import java.util.UUID;

public class Order {
    private UUID orderId;
    private String customerName;
    private UUID productId;
    private int quantity;
    private OrderStatus orderStatus;

    public enum OrderStatus {
        PENDING, SHIPPED, DELIVERED
    }

    public Order(String customerName, UUID productId, int quantity) {
        this.orderId = UUID.randomUUID();
        this.customerName = customerName;
        this.productId = productId;
        this.quantity = quantity;
        this.orderStatus = OrderStatus.PENDING;
    }

    // Getters and Setters
    public UUID getOrderId() {
        return orderId;
    }
    public String getCustomerName() {
        return customerName;
    }
    public UUID getProductId() {
        return productId;
    }
    public int getQuantity() {
        return quantity;
    }
    public OrderStatus getOrderStatus() {
        return orderStatus;
    }
    public void setOrderStatus(OrderStatus orderStatus) {
        this.orderStatus = orderStatus;
    }
}
