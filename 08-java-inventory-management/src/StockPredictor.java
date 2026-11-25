public class StockPredictor {
    public static void predictStockDepletion(Product product, int dailySales) {
        int daysUntilOutOfStock = product.getStockLevel() / dailySales;
        String restockSuggestion = (daysUntilOutOfStock <= 5) ? "Moderate: Consider restocking soon." : "No immediate need to restock.";

        System.out.println("Stock Prediction for " + product.getName() + ":");
        System.out.println("Days until stock out: " + daysUntilOutOfStock);
        System.out.println("Restock Suggestion: " + restockSuggestion);
        System.out.println("----------------------------");
    }
}
