import java.util.*;

class Order {
    int orderID;
    int userID;
    List<OrderDetails> orderDetails;

    public Order(int userID, int orderID) {
        this.userID = userID;
        this.orderID = orderID;
        this.orderDetails = new ArrayList<>();
    }

    public void addOrderDetail(OrderDetails detail) {
        orderDetails.add(detail);
    }

    @Override
    public String toString() {
        StringBuilder orderInfo = new StringBuilder("Order ID: " + orderID + ", User ID: " + userID + ", Items: ");
        for (OrderDetails detail : orderDetails) {
            orderInfo.append("\n\t" + detail);
        }
        return orderInfo.toString();
    }
}
