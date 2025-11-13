using BarCodeScannerApi.Data.Context;
using SharedKernel.Models;

namespace BarCodeScannerApi.Data;

public static class DbSeeder
{
    public static void Seed(BarcodeContext context)
    {
        context.Database.EnsureCreated();

        if (context.Items.Any()) return;

        var items = new List<Item>
        {
            new Item
            {
                EAN = 0812130020533,
                Title = "Truvia Original Calorie-Free Sweetener from The Stevia Leaf  80 Count (5.64 oz Carton)",
                Description =
                    "Sweetness is meant to be enjoyed. That s why Truvia created products meant to reduce sugar  not taste. The clean  sweet flavor contained in Truvia Original Calorie-Free Sweetener packets comes from nature in the form of the stevia leaf. Leaves don t dissolve well in beverages or baked goods  so we extract the sweetness from the stevia leaf. Because stevia leaf extract is 200x sweeter than sugar  we balance the sweetness with erythritol  a sweetener produced by fermentation. Erythritol is also found in fruits like grapes and pears. This gives you the white crystals you re used to without the calories. Truvia Original Calorie-Free Sweetener from the Stevia Leaf  80 Packets (5.64 oz Carton) is just the right size to fit on your counter or in your pantry.",
                UPC = 812130020533,
                Brand = "Truvia",
                Model = "KHFM00321290",
                Color = "Gray",
                Size = "",
                Dimension = "",
                Category = "Food, Beverages & Tobacco > Food Items > Cooking & Baking Ingredients",
                Images =
                [
                    "https://i5.walmartimages.com/asr/74dd3f3f-2772-448d-9b38-fc42b8d67b63.6753bf8e0733f265e1b7bd21f0e225b2.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff",
                    "https://target.scene7.com/is/image/Target/GUEST_15fbc545-d83e-409c-8add-370a7b920654?wid=1000&hei=1000",
                    "https://c1.neweggimages.com/ProductImageCompressAll640/AC8Z_1_201905091118006098.jpg",
                    "http://site.unbeatablesale.com/GRNDR38150.JPG",
                    "https://tshop.r10s.com/44e/68b/8b4f/5681/4072/7ce2/2b0d/11f4e989030242ac110005.jpg?_ex=512x512"
                ],
            },
            new Item
            {
                EAN = 0041271025903,
                Title = "CREAMER SINGLES",
                Description =
                    "INGREDIENTS: WATER, CANE SUGAR, PALM OIL, CONTAINS 2% OR LESS OF: SODIUM CASEINATE* (A MILK DERIVATIVE), DIPOTASSIUM PHOSPHATE, NATURAL AND ARTIFICIAL FLAVORS, MONO AND DIGLYCERIDES, SODIUM STEAROYL LACTYLATE, POLYSORBATE 60, CARRAGEENAN, SALT.",
                UPC = 041271025903,
                Brand = "International Delight",
                Model = "100681",
                Color = "Black",
                Size = "",
                Dimension = "12 X 5 X 8 inches",
                Category = "Food, Beverages & Tobacco > Beverages > Non-Dairy Milk",
                Images =
                [
                    "https://i5.walmartimages.com/asr/53087b70-c1bc-438c-909e-299ef8c8e627.38061aa8a33c386b806747a8c9b9bb77.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff",
                    "https://target.scene7.com/is/image/Target/GUEST_543e7b7e-4b19-4375-9640-19e7acd62d2a?wid=1000&hei=1000",
                    "https://pics.drugstore.com/prodimg/475241/450.jpg",
                    "http://site.unbeatablesale.com/img485/usitd100681.gif",
                    "http://c.shld.net/rpx/i/s/pi/mp/4143/7758193418?src=http%3A%2F%2Ficdn.tonzof.com%2F3%2F5%2F4%2F354600000326544%2F175705.JPG&d=d4d6e29fc9c3165a0029698cc8d33b0f018caab4",
                    "http://ct.mywebgrocer.com/legacy/productimagesroot/DJ/4/17104.jpg",
                    "https://www.staples-3p.com/s7/is/image/Staples/s1144412_sc7?$enl$",
                    "http://s3images.shopletcdn.com/productimages/500x500/175705.JPG",
                    "http://content.oppictures.com/Master_Images/Master_Variants/Variant_100/175705.JPG",
                    "http://images10.newegg.com/ProductImageCompressAll200/A1PC_1_20160522704625762.jpg"
                ],
            },
            new Item
            {
                EAN = 0097855046871,
                Title = "Logitech - H390 Wired USB On-Ear Stereo Headphones - Black",
                Description =
                    "Rotating, noise-canceling microphone; in-line audio controls; plug-and play connectivity; adjustable, padded headband; plush ear pads",
                UPC = 097855046871,
                Brand = "Logitech",
                Model = "4248577",
                Color = "Multi-Color",
                Size = "11.2 oz",
                Dimension = "9.9 X 7.4X 1.9 inches",
                Category = "Electronics > Audio > Audio Components > Headphones & Headsets > Headphones",
                Images =
                [
                    "https://media.officedepot.com/images/t_extralarge%2Cf_auto/products/607890/607890_o01/1.jpg",
                    "https://i5.walmartimages.com/asr/643338dc-13d6-4f37-a4b8-2812a1f4806f.aca52f667886761e78300c43faa11fb9.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff",
                    "http://www.adorama.com/images/large/LOCCUSB.JPG",
                    "http://site.unbeatablesale.com/img017/dh981000014.jpg",
                    "http://www.meijer.com/assets/product_images/styles/xlarge/1000947_097855046871_A_400.jpg",
                    "http://c.shld.net/rpx/i/s/pi/mp/10140351/9468567919?src=http%3A%2F%2Fcontent.oppictures.com%2FMaster_Images%2FMaster_Variants%2FVariant_240%2F61602.jpg&d=c1412665460a941d41c3b4b4bd138406f0278e78",
                    "https://images.frys.com/art/product/300x300/5556690.01.prod.jpg",
                    "https://pisces.bbystatic.com/prescaled/500/500/image2/BestBuy_US/images/products/f8e8eb6a-05c8-4a84-8694-d4fbc835a82a.jpg",
                    "https://slimages.macysassets.com/is/image/MCY/products/4/optimized/22913114_fpx.tif?wid=1200&fmt=jpeg&qlt=100",
                    "https://target.scene7.com/is/image/Target/GUEST_bad18e6b-1835-41fe-8b4b-0b4ece6cb1e1?wid=1000&hei=1000"
                ],
            },
            new Item
            {
                EAN = 0037000405092,
                Title = "Swiffer Dusters Dusting Starter Kit - 6ct",
                Description =
                    "Swiffer Dusters TRAP + LOCK dust and remove up to 95% of allergens**. And, with thousands of fluffy, specially coated fibers, Swiffer Dusters grab onto dust and don't let go. Use Swiffer Dusters for cleaning wherever dust shows up, including fan blades, blinds, car interior, keyboard vents, bookcases and more. **Common inanimate allergens from cat and dog dander and dust mite matter",
                UPC = 037000405092,
                Brand = "Swiffer",
                Model = "40509",
                Color = "Gold Golden",
                Size = "6",
                Dimension = "12.5 X 5 X 7.8 inches",
                Category = "Health & Beauty > Personal Care",
                Images =
                [
                    "https://pics.walgreens.com/prodimg/83796/450.jpg",
                    "https://media.officedepot.com/images/t_extralarge%2Cf_auto/products/115864/115864_o01_122222/1.jpg",
                    "https://images.thdstatic.com/productImages/e2cb8f00-b46f-41ff-8f08-6d30c3e04aff/svn/swiffer-dusters-003700011804-64_1000.jpg",
                    "https://target.scene7.com/is/image/Target/GUEST_0fd08001-78e3-41cc-9592-b9e7cf3c1675?wid=1000&hei=1000",
                    "http://images.lowes.com/product/converted/037000/037000405092lg.jpg",
                    "http://www.build.com/imagebase/resized/x800/Swifferimages/swiffer-pgc40509-525.jpg",
                    "http://site.unbeatablesale.com/MCDS22777.JPG",
                    "http://c.shld.net/rpx/i/s/pi/mp/15443/8953334019?src=https%3A%2F%2Fd1n77ujlkvior7.cloudfront.net%2Fmedia%2FZApATzrWgBXiG51YL6ucsU5hlLzwUh18-13.jpg&d=dbda7ea79446bf33c9e70d4b1a59df0244384730",
                    "http://c.shld.net/rpx/i/s/i/spin/10127449/prod_ec_2086902302",
                    "http://pics1.ds-static.com/prodimg/83796/300.jpg"
                ],
            },
            new Item
            {
                EAN = 0611247401286,
                Title = "Keurig  ICED Coffeehouse Variety Pack Medium Roast K-Cup Coffee Pods  24 count",
                Description =
                    "Our Iced Coffeehouse K-Cup? pod collection brings the ultimate caf?-quality experience to your kitchen with four varieties filled with refreshing flavors made deliciously simple ? all at the push of a button. The Original Donut Shop? Coffee Iced Duos? Cookies + Caramel coffee blends the fresh-baked flavors of sugar cookies and buttery caramel for a sweet duet of delicious  perfectly roasted harmony. McCaf? Iced Mocha Frapp? is an all-time favorite that boasts a decadent  chocolatey flavor  and McCaf? Iced Hazelnut Latte delivers the sweet  nutty hazelnut flavor you love. Each McCaf? K-Cup? pod is filled with rich coffee  natural flavors  sweetener  and real dairy ? all in one. Green Mountain Coffee Roasters? Brew Over Ice Vanilla Caramel is a refreshing blend of creamy vanilla and buttery caramel flavors. Every flavor in this collection is made to stand up to ice and is compatible with any Keurig? single serve coffee maker. To brew an iced coffee  fill a large tumbler with ice. DO NOT us",
                UPC = 611247401286,
                Brand = "Keurig",
                Model = "Keurig",
                Color = "",
                Size = "24 ct",
                Dimension = "",
                Category = "",
                Images =
                [
                    "https://media.officedepot.com/images/t_extralarge%2Cf_auto/products/6813032/6813032_o01/1.jpg",
                    "https://i5.walmartimages.com/asr/f03e4efd-22c9-4803-9be8-aa4302c95e0c.ea0dca857e1c651018c4f7a9208b52d3.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff",
                    "https://products.blains.com/600/161/1618643.jpg"
                ],
            },
        };

        context.Items.AddRange(items);
        context.SaveChanges();
    }
}