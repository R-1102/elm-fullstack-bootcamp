// Product Classes (Electronics, Clothing, Footwear)
abstract class Product {
    int id;
    String name;
    double price;
    int stockQuantity;

    public Product(int id, String name, double price, int stockQuantity) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.stockQuantity = stockQuantity;
    }

    public void reduceStock(int quantity) throws OutOfStockException {
        if (stockQuantity < quantity) {
            throw new OutOfStockException("Product " + name + " is out of stock!");
        }
        stockQuantity -= quantity;
    }

    @Override
    public String toString() {
        return name + " (ID: " + id + ")";
    }
}

class Electronics extends Product {
    int warrantyMonths;

    public Electronics(int id, String name, double price, int stockQuantity) {
        super(id, name, price, stockQuantity);
    }
}

class Footwear extends Product {
    String size;

    public Footwear(int id, String name, double price, int stockQuantity, String size) {
        super(id, name, price, stockQuantity);
        this.size = size;
    }
}

class Clothing extends Product {
    String size;

    public Clothing(int id, String name, double price, int stockQuantity, String size) {
        super(id, name, price, stockQuantity);
        this.size = size;
    }
}

class OutOfStockException extends Exception {
    public OutOfStockException(String message) {
        super(message);
    }
}