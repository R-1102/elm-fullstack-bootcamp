
class OrderDetails {
    int orderDetailID;
    int orderID;
    int productID;
    int quantity;
    double subTotal;

    public OrderDetails(int orderDetailID, int orderID, int productID, int quantity, double subTotal) {
        this.orderDetailID = orderDetailID;
        this.orderID = orderID;
        this.productID = productID;
        this.quantity = quantity;
        this.subTotal = subTotal;
    }

    @Override
    public String toString() {
        return "Product ID: " + productID + ", Quantity: " + quantity + ", SubTotal: " + subTotal;
    }
}

