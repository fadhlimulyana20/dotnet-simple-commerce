using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using dotnet_mvc.Data;
using System;
using System.Linq;

namespace dotnet_mvc.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new DotnetMvcContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<DotnetMvcContext>>()))
        {
            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    Name = "Konsol Game Sony Playstation 5 Play Station 5 PS 5 PS5 Slim Disc Digital - Slim Digita",
                    Sku = "ps5-slim",
                    Description = @"
                        Sony PlayStation5 Dics Digital

                        Deskripsi Singkat:
                        PlayStation 5 (PS5) adalah konsol game terbaru dari Sony yang menawarkan pengalaman gaming tingkat lanjut, Konsol ini juga mendukung retrokompatibilitas dengan sebagian besar game PS4 dan menawarkan akses ke PlayStation Plus Collection, memberikan berbagai judul game PS4 populer kepada pelanggan PlayStation Plus. Dengan game eksklusif yang mengesankan seperti Demon's Souls dan Spider-Man: Miles Morales, PS5 menjadi pilihan utama bagi para gamer yang menginginkan pengalaman gaming terbaik di kelasnya.

                        Fitur Utama:
                        - Hardware Kuat: PS5 memiliki mesin yang canggih dengan grafis 4K yang tajam dan pergerakan
                        halus hingga 120fps.
                        - SSD Cepat: Waktu pemuatan yang cepat berkat SSD kustom, sehingga pemain bisa langsung
                        terjun ke permainan tanpa menunggu.
                        - DualSense Controller: Pengontrol baru, DualSense, memberikan sensasi yang lebih imersif
                        dengan getaran responsif dan tombol yang bisa disesuaikan.
                        - Interaksi Lancar: Beralih antara permainan, streaming, dan aplikasi multimedia dengan mudah.

                        Spesifikasi :
                        - Launch: Nov 2020
                        - CPU : 8-core AMD Zen 2 (3,5 Hz)
                        - Penyimpanan: 825 GB
                        - Grafis: 4K UHD
                        - Ram: 16GB
                        - Koneksi: Wi-Fi IEEE 802.11ax Bluetooth 5.1

                        Isi Paket:
                        - Konsol PS5
                        - DualSense Controller
                        - Kabel HDMI, Power Dan USB

                        Pilihan Garansi :
                        - Garansi Resmi Sony Playstation 5
                        - Garansi Toko 7 hari / 1 Tahun: Produk akan diperbaiki atau diganti baru karena cacat pabrikan tanpa biaya tambahan selama periode garansi yang dipilih (7 hari atau 1 tahun) (Entraverse).*

                        *Baca catatan toko tentang Ketentuan Garansi untuk info lebih lanjut.

                        PlayStation 5 aksesoris tambahan:
                        - Tambahan DualSense Wireless Controller PS5 https://tokopedia.link/TWsTQqy59Kb
                        - Bawa PS5 untuk digunakan secara portable dari jarak jauh, memperkenalkan PlayStation 5 Portal https://tokopedia.link/CZmZ4hD59Kb
                    ",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Black_and_white_Playstation_5_base_edition_with_controller.png/188px-Black_and_white_Playstation_5_base_edition_with_controller.png",
                    Price = 7554000
                },
                new Product
                {
                    Name = "Nintendo Switch Lite Console Mesin - New Blue",
                    Sku = "nintendo-switch-lite",
                    Description = @"
                        Belum termasuk game
                        hanya console , dus dan charger .

                        Garansi toko 7 Hari, terhitung sejak barang diterima,
                        tidak perlu ragu beli di kami, jaminan official store, jaminan barang original, jelas toko nya, jelas pelayanan nya. Fast respon dan Fast shipping !


                        Kelengkapan :
                        1x unit console Nintendo Switch Lite
                        1x Adaptor original
                        1x Dus/Box

                        * Berbeda dengan Nintendo Switch yang dapat berfungsi sebagai konsol game hybrid, justru Nintendo Switch Lite dirancang khusus untuk penggunaan yang benar-benar portabel.
                        * Karenanya, versi Lite ini kehilangan beberapa fitur khas yang dimiliki Nintendo Switch. Seperti tidak dapat terhubung ke televisi, hingga tidak bisa dibongkar pasang layaknya Switch versi reguler.
                        * Namun, Switch Lite memiliki berbagai macam keunggulan. Mulai dari desain yang kompak dan ergonomis, hingga performa yang powerful namun tetap efisien. Membuatnya jadi handled console idaman terbaik.

                        Butuh Tempered Glass ?
                        https://www.tokopedia.com/butikgames/tempered-glass-nintendo-switch-lite-anti-gores-screen-protector-switch

                        Butuh Game ?
                        https://www.tokopedia.com/butikgames/etalase/nintendo-switch-game

                        Butuh Aksesories Switch Lainnya?
                        https://www.tokopedia.com/butikgames/etalase/nintendo-switch-aksesories-1

                        Butuh console/mesin switch yang lain ?
                        https://www.tokopedia.com/butikgames/etalase/nintendo-switch

                        Mau yang CFW bisa di isi game ?
                        https://www.tokopedia.com/butikgames/nintendo-switch-lite-cfw-full-game
                        https://www.tokopedia.com/butikgames/nintendo-switch-lite-cfw-256gb-full-gamehttps://www.tokopedia.com/butikgames/nintendo-switch-lite-cfw-128gb-full-game

                        GARANSI TOKO 7 HARI TERHITUNG SEJAK BARANG DITERIMA,
                        GARANSI TIDAK BERLAKU JIKA TERJADI HUMMAN ERROR/SEGEL RUSAK/CACAT FISIK & UNSUR DISENGAJA LAINNYA.
                    ",
                    ImgUrl = "https://www.nintendo.com/eu/media/images/08_content_images/systems_5/nintendo_switch_3/nintendo_switch_lite_2/NSwitchLiteHandsTurqouise_image950w.png",
                    Price = 2300000
                },
                new Product
                {
                    Name = "Xbox Series S Console Mesin XSS Microsoft XBOX Series S - Putih 512GB",
                    Sku = "xbox-series-s",
                    Description = @"
                        GARANSI TOKO 1 Minggu

                        (Pilih varian Putih 512GB atau Hitam 1TB)

                        The next generation of gaming brings our largest digital launch library yet to our smallest Xbox ever. With more dynamic worlds, faster load times, and the addition of Xbox Game Pass (sold separately), the all-digital Xbox Series S is the best value in gaming.
                        Experience next-gen speed and performance with Xbox Series S in Carbon Black, featuring a 1TB SSD.

                        Content Packages
                        1x Xbox Series S console
                        1x Xbox Wireless Controller
                        1x High Speed HDMI cable
                        1x Cable Power
                        2x Pcs Baterai A2

                        Butuh akun gamepass ?
                        https://www.tokopedia.com/butikgames/xbox-gamepass-game-pass-ultimate

                        Butuh aksesories tambahan ?
                        https://www.tokopedia.com/butikgames/etalase/aksesories-microsoft-xbox-1
                    ",
                    ImgUrl = "https://cms-assets.xboxservices.com/assets/bf/b0/bfb06f23-4c87-4c58-b4d9-ed25d3a739b9.png?n=389964_Hero-Gallery-0_A1_857x676.png",
                    Price = 3500000
                },
                new Product
                {
                    Name = "Xbox Series X Console Mesin Microsoft XBOX 1TB Mesin XSX",
                    Sku = "xbox-series-x",
                    Description = @"
                        XBOX series X  1TB

                        Region Jepang

                        Kelengkapan : 
                        1x Unit console XBOX series X
                        1x pcs Stick Wireless Controller
                        1x HDMI High Speed
                        1x Power Adaptor
                        2x Baterai A2 for controller

                        GARANSI Toko 7 hari sejak barang diterima

                        Butuh akun gamepass ?
                        https://www.tokopedia.com/butikgames/xbox-gamepass-game-pass-ultimate

                        *) catatan :
                        untuk garansi, klaim sendiri ke Singapore, kami tidak bisa bantu untuk klaim garansi nya.
                    ",
                    ImgUrl = "https://cms-assets.xboxservices.com/assets/bf/b0/bfb06f23-4c87-4c58-b4d9-ed25d3a739b9.png?n=389964_Hero-Gallery-0_A1_857x676.png",
                    Price = 7498000
                },
                new Product
                {
                    Name = "Xbox Wireless Controller - Pulse Red",
                    Sku = "xbox-wireless-controller",
                    Description = @"
                        Xbox Wireless Controller - Pulse Red
                        Kompatibel untuk Xbox Series X, Xbox Series S, Xbox One, Windows 10/11, Android, dan iOS

                        • Rasakan desain Pengontrol Nirkabel Xbox seri Carbon Black yang modern dengan permukaan yang diukir, geometris, dan presisi untuk meningkatkan kenyamanan selama bermain game dengan ketahanan baterai hingga 40 jam.

                        • Tepat sasaran dengan D-pad hybrid baru, permukaan bertekstur pada trigger, bumper, dan casing belakang. Sambungkan headset apa pun yang kompatibel dengan audio jack 3,5 mm.

                        • Sambungkan menggunakan port USB-C untuk memasangkan dan memainkan langsung ke konsol atau PC. Dukungan untuk baterai AA disertakan di bagian belakang.

                        • Tangkap dan bagikan konten dengan lancar menggunakan tombol Bagikan.

                        • Buat pengontrol Anda sendiri dengan pemetaan tombol kustom pada aplikasi Xbox Accessories.

                        • Dilengkapi teknologi Xbox Nirkabel dan Bluetooth® untuk gaming nirkabel di konsol yang didukung PC Windows 10/11, serta ponsel dan tablet Android dan iOS.

                        • SKU = EP2-01732

                        • Garansi 12 bulan
                    ",
                    ImgUrl = "https://images.tokopedia.net/img/cache/900/VqbcmM/2024/9/10/aa718558-a314-4840-82aa-543d89093f66.png",
                    Price = 939000
                },
                 new Product
                {
                    Name = "Rexus GX300 / GX-300 Gamepad Joystick Bluetooth Wireless - Putih, V1+Jempol",
                    Sku = "xbox-wireless-controller",
                    Description = @"
                        Tambahan Fitur Di Gen 2 :
                        - Ada fitur tombol MACRO di belakang GAMEPAD Asteria
                        - Joystick 3D Hall Effect Analog

                        Specifications :
                        Technology : bluetooth 4.2
                        Battery : Lithium Polymer 600mAh
                        Playing time : 8-10 hours
                        Charging time : 2-3 Hours
                        Analog Sticks : Eccentric 360
                        Compatibility :
                        PlayStation 4
                        Compatible with PC (via X-input)
                        Compatible with Android (Via Bluetooth)

                        Light : LED Indicators
                        Charging Cable Length : 1.5M Type - C charging cable
                        Dimension : 156mmx106mmx51mm
                        Weight : 256 Gram

                        Product Features
                        Sensitive Trigger for realistis gaming experience
                        Bluetooth Gamepad (Version 4.2) compatible with PS4
                        With 3.5mm TRRS stereophoniv hole, support mic and headset front with beautiful light tube
                        Hand Grip with texture
                        With two programmable back buttons
                    ",
                    ImgUrl = "https://images.tokopedia.net/img/cache/900/VqbcmM/2023/6/30/03280aa6-7b19-4492-a69f-501a6904a6f6.jpg",
                    Price = 239000
                }
            );
            context.SaveChanges();
        }
    }
}