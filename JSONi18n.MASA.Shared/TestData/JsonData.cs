namespace JSONi18n.MASA.Shared.TestData;

public static class JsonData
{
    public const string en_US = /*lang=json,strict*/ """
        {
          "title": "Random Data",
          "description": "This is a randomly generated JSON data.",
          "nestedObject": {
            "name": "John Doe",
            "age": "25"
          },
          "items": [
            "Item 1",
            "Item 2",
            "Item 3"
          ],
          "specialCharacters": "!@#$%^&*()",
          "specialCharacters2": "!@#(hello)$%weoroldf 及法律途径 ^&*(",
          "message": "Hello {{name}}! How are you today?",
          "menuItems": [
          "Home",
          "Products",
          "Services",
          "Contact"
          ]
        }
        """;

    public const string zh_CN = /*lang=json,strict*/ """
        {
          "title": "随机数据",
          "description": "这是一段随机生成的 JSON 数据。",
          "nestedObject": {
            "name": "张三",
            "age": "25岁"
          },
          "items": [
            "物品1",
            "物品2",
            "物品3"
          ],
          "specialCharacters": "!@#$%^&*()",
          "specialCharacters2": "!@#(你好)$%weoroldf and the way of law ^&*(",
          "message": "你好，{{name}}！你今天好吗？",
          "menuItems": [
          "主页",
          "产品",
          "服务",
          "联系我们"
          ]
        }
        """;
}
