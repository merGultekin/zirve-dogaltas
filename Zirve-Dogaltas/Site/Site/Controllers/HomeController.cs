using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {
            ViewBag.MetaTitle = "Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            return View();
        }
        public ActionResult Kurumsal()
        {
            ViewBag.MetaTitle = "Kurumsal - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";


            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            // ÜRETİM TESİSİ
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Üretim - 1", ImageFileUrl = "/UserFiles/Images/UretimTesis/1.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Üretim - 2", ImageFileUrl = "/UserFiles/Images/UretimTesis/2.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Üretim - 3", ImageFileUrl = "/UserFiles/Images/UretimTesis/3.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Üretim - 4", ImageFileUrl = "/UserFiles/Images/UretimTesis/4.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Üretim - 5", ImageFileUrl = "/UserFiles/Images/UretimTesis/5.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Üretim - 6", ImageFileUrl = "/UserFiles/Images/UretimTesis/6.jpg" });


            // EBAT
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 1", ImageFileUrl = "/UserFiles/Images/UretimEbat/1.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 2", ImageFileUrl = "/UserFiles/Images/UretimEbat/2.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 3", ImageFileUrl = "/UserFiles/Images/UretimEbat/3.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 4", ImageFileUrl = "/UserFiles/Images/UretimEbat/4.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 5", ImageFileUrl = "/UserFiles/Images/UretimEbat/5.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 6", ImageFileUrl = "/UserFiles/Images/UretimEbat/6.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 7", ImageFileUrl = "/UserFiles/Images/UretimEbat/7.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 8", ImageFileUrl = "/UserFiles/Images/UretimEbat/8.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 9", ImageFileUrl = "/UserFiles/Images/UretimEbat/9.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 10", ImageFileUrl = "/UserFiles/Images/UretimEbat/10.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 11", ImageFileUrl = "/UserFiles/Images/UretimEbat/11.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 12", ImageFileUrl = "/UserFiles/Images/UretimEbat/12.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 13", ImageFileUrl = "/UserFiles/Images/UretimEbat/13.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 14", ImageFileUrl = "/UserFiles/Images/UretimEbat/14.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 15", ImageFileUrl = "/UserFiles/Images/UretimEbat/15.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 16", ImageFileUrl = "/UserFiles/Images/UretimEbat/16.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 17", ImageFileUrl = "/UserFiles/Images/UretimEbat/17.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 18", ImageFileUrl = "/UserFiles/Images/UretimEbat/18.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 19", ImageFileUrl = "/UserFiles/Images/UretimEbat/19.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 1, Title = "Ebatlama - 20", ImageFileUrl = "/UserFiles/Images/UretimEbat/20.jpg" });


            // PAH
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 1, Title = "Pah - 1", ImageFileUrl = "/UserFiles/Images/UretimPah/1.jpg" });
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 1, Title = "Pah - 2", ImageFileUrl = "/UserFiles/Images/UretimPah/2.jpg" });
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 1, Title = "Pah - 3", ImageFileUrl = "/UserFiles/Images/UretimPah/3.jpg" });
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 1, Title = "Pah - 4", ImageFileUrl = "/UserFiles/Images/UretimPah/4.jpg" });


            // DEKORASYON
            model.ProductList.Add(new Product() { TypeId = 4, OrderNo = 1, Title = "Dekorasyon - 1", ImageFileUrl = "/UserFiles/Images/UretimDekorasyon/1.jpg" });
            model.ProductList.Add(new Product() { TypeId = 4, OrderNo = 1, Title = "Dekorasyon - 2", ImageFileUrl = "/UserFiles/Images/UretimDekorasyon/2.jpg" });
            model.ProductList.Add(new Product() { TypeId = 4, OrderNo = 1, Title = "Dekorasyon - 3", ImageFileUrl = "/UserFiles/Images/UretimDekorasyon/3.jpg" });


            return View(model);
        }

        public ActionResult Referanslar()
        {
            ViewBag.MetaTitle = "Referanslar - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();


            model.ProductList.Add(new Product() {TypeId = 1, Title = "Rönesans Bodrum Yalıkavak Otel", ImageFileUrl = "/UserFiles/Images/Referanslar/ronesans-bodrum-yalikaval-otel.jpg" });
            model.ProductList.Add(new Product() {TypeId = 1, Title = "Rönesans Protokol Yolu Yön. Binası", ImageFileUrl = "/UserFiles/Images/Referanslar/ronesans-protokol-yolu-yonetim-binasi.jpg" });
            model.ProductList.Add(new Product() {TypeId = 1, Title = "Zorlu Center Apple Mağazası", ImageFileUrl = "/UserFiles/Images/Referanslar/zorlu-center-apple-magaza.jpg" });
            model.ProductList.Add(new Product() {TypeId = 1, Title = "Pemaks Dilovası OSB Fabrikası", ImageFileUrl = "/UserFiles/Images/Referanslar/pemaks-dilovasi-osb-fabrikasi.jpg" });
            model.ProductList.Add(new Product() {TypeId = 1, Title = "Seçkin Büro Gebze Fabrikası", ImageFileUrl = "/UserFiles/Images/Referanslar/seckin-buro-gebze-fabrikasi.jpg" });
            model.ProductList.Add(new Product() {TypeId = 1, Title = "Geta Grup Şirketi Tuzla OSB Fabrikası", ImageFileUrl = "/UserFiles/Images/Referanslar/geta-grup-sirketi-tuzla-osb-fabrikasi.jpg" });

            return View(model);
        }

        public ActionResult Granit()
        {
            ViewBag.MetaTitle = "Granit - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";


            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            
            // Type = 1  Granit

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Emerald Pearl", ImageFileUrl = "/UserFiles/Images/Granit/emerald_pearl.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 2, Title = "Blue Pearl", ImageFileUrl = "/UserFiles/Images/Granit/blue_pearl.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 3, Title = "Nero Zimbabwe", ImageFileUrl = "/UserFiles/Images/Granit/nero_zimbabwe.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 4, Title = "Star Galaxy", ImageFileUrl = "/UserFiles/Images/Granit/star_galaxy.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 5, Title = "Green Butterfly", ImageFileUrl = "/UserFiles/Images/Granit/green_butterfly.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 6, Title = "Black Marinace", ImageFileUrl = "/UserFiles/Images/Granit/black_marinace.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 7, Title = "Green Marinace", ImageFileUrl = "/UserFiles/Images/Granit/green_marinace.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 8, Title = "Giallo Ornamantale", ImageFileUrl = "/UserFiles/Images/Granit/giallo_ornamantale.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 9, Title = "Baltic Brown", ImageFileUrl = "/UserFiles/Images/Granit/baltic_brown.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 10, Title = "White Rose", ImageFileUrl = "/UserFiles/Images/Granit/white_rose.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 11, Title = "Giallo Fiorito", ImageFileUrl = "/UserFiles/Images/Granit/giallo_fiorito.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 12, Title = "Bianco Nublado", ImageFileUrl = "/UserFiles/Images/Granit/bianco_nublado.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 13, Title = "Rosavel", ImageFileUrl = "/UserFiles/Images/Granit/rosavel.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 14, Title = "Rosa Minho", ImageFileUrl = "/UserFiles/Images/Granit/rosa_minho.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 15, Title = "Rosa Beta", ImageFileUrl = "/UserFiles/Images/Granit/rosa_beta.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 16, Title = "Azul Platino", ImageFileUrl = "/UserFiles/Images/Granit/azul_platino.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 17, Title = "Rosa Porino", ImageFileUrl = "/UserFiles/Images/Granit/rosa_porino.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 18, Title = "Crema Perla", ImageFileUrl = "/UserFiles/Images/Granit/crema_perla.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 19, Title = "Absolute Black", ImageFileUrl = "/UserFiles/Images/Granit/absoluteblack.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 20, Title = "ASH Black", ImageFileUrl = "/UserFiles/Images/Granit/ash_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 21, Title = "Tan Brown", ImageFileUrl = "/UserFiles/Images/Granit/tan_brown.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 22, Title = "Verdestar", ImageFileUrl = "/UserFiles/Images/Granit/verdestar.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 23, Title = "New Imperial", ImageFileUrl = "/UserFiles/Images/Granit/new_imperial.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 24, Title = "G20 Black", ImageFileUrl = "/UserFiles/Images/Granit/g_20_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 25, Title = "Black Magic", ImageFileUrl = "/UserFiles/Images/Granit/black_magic.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 26, Title = "Premium White", ImageFileUrl = "/UserFiles/Images/Granit/premium_white.jpg" });
            model.ProductList.Add(new Product() { TypeId = 2, OrderNo = 27, Title = "Rose Pink", ImageFileUrl = "/UserFiles/Images/Granit/rose_pink.jpg" });


            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Carmen Red",         ImageFileUrl = "/UserFiles/Images/Granit/carmen_red.jpg" });

            /// Type = 2  Hint

            // Type = 3  Vietnam
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 81, Title = "DN White", ImageFileUrl = "/UserFiles/Images/Granit/dn_white.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 82, Title = "PM White", ImageFileUrl = "/UserFiles/Images/Granit/pm_white.jpg" });
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 83, Title = "SL White", ImageFileUrl = "/UserFiles/Images/Granit/sl_white.jpg" });
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 84, Title = "V Nublado", ImageFileUrl = "/UserFiles/Images/Granit/v_nublado.jpg" });
            model.ProductList.Add(new Product() { TypeId = 3, OrderNo = 85, Title = "PC Violet", ImageFileUrl = "/UserFiles/Images/Granit/pc_violet.jpg" });


            return View(model);
        }
        public ActionResult Mermer()
        {
            ViewBag.MetaTitle = "Mermer - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Alexandir Black", ImageFileUrl = "/UserFiles/Images/Mermer/alexandir_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 2, Title = "Bianco Carrara", ImageFileUrl = "/UserFiles/Images/Mermer/bianco_carera.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 3, Title = "Calacatta Oro", ImageFileUrl = "/UserFiles/Images/Mermer/calacatta_oro.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 4, Title = "Black Forest", ImageFileUrl = "/UserFiles/Images/Mermer/black_forest.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 5, Title = "Nero Marquina", ImageFileUrl = "/UserFiles/Images/Mermer/nero_marquina.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 6, Title = "Pietra Grey", ImageFileUrl = "/UserFiles/Images/Mermer/pietra_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 7, Title = "Emperador Dark", ImageFileUrl = "/UserFiles/Images/Mermer/emperador_dark.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 8, Title = "Sivec", ImageFileUrl = "/UserFiles/Images/Mermer/sivec.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 9, Title = "Emperador Black",         ImageFileUrl = "/UserFiles/Images/Mermer/emperador_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 10, Title = "Volakas",            ImageFileUrl = "/UserFiles/Images/Mermer/volakas.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 11, Title = "Emperador Light",    ImageFileUrl = "/UserFiles/Images/Mermer/emperador_brown.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 12, Title = "Tundra", ImageFileUrl = "/UserFiles/Images/Mermer/tundra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 13, Title = "White Serpeggiante", ImageFileUrl = "/UserFiles/Images/Mermer/white_serpeggiante.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 14, Title = "Dark Serpeggiante", ImageFileUrl = "/UserFiles/Images/Mermer/dark_serpeggiante.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 15, Title = "Rainforest Green", ImageFileUrl = "/UserFiles/Images/Mermer/rainforest_green.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 16, Title = "Rainforest Brown", ImageFileUrl = "/UserFiles/Images/Mermer/rainforest_brown.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 17, Title = "Olive Maron", ImageFileUrl = "/UserFiles/Images/Mermer/olive_maron.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 18, Title = "Ege Kahve", ImageFileUrl = "/UserFiles/Images/Mermer/ege_kahve.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 19, Title = "Silver Grey", ImageFileUrl = "/UserFiles/Images/Mermer/silver_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 20, Title = "Savana Grey", ImageFileUrl = "/UserFiles/Images/Mermer/savana_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 21, Title = "Cool Jade", ImageFileUrl = "/UserFiles/Images/Mermer/cool_jade.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 22, Title = "Oracle Grey", ImageFileUrl = "/UserFiles/Images/Mermer/oracle_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 23, Title = "Amazon", ImageFileUrl = "/UserFiles/Images/Mermer/amazon.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 24, Title = "Portoro Gold", ImageFileUrl = "/UserFiles/Images/Mermer/portoro_gold.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 25, Title = "Century Black", ImageFileUrl = "/UserFiles/Images/Mermer/century_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 26, Title = "Alanya Black", ImageFileUrl = "/UserFiles/Images/Mermer/alanya_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 27, Title = "Klasik Grey", ImageFileUrl = "/UserFiles/Images/Mermer/klasik_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 28, Title = "Panda White", ImageFileUrl = "/UserFiles/Images/Mermer/panda_white.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 29, Title = "Oracle Brown", ImageFileUrl = "/UserFiles/Images/Mermer/oracle_brown.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 30, Title = "Dr White", ImageFileUrl = "/UserFiles/Images/Mermer/dr_white.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 31, Title = "Wolakas Flower", ImageFileUrl = "/UserFiles/Images/Mermer/wolakas_flower.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 32, Title = "Serpeciante Blue", ImageFileUrl = "/UserFiles/Images/Mermer/sepeciante_blue.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 33, Title = "Royal Yellow", ImageFileUrl = "/UserFiles/Images/Mermer/royal_yellow.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 34, Title = "Bruno Perla", ImageFileUrl = "/UserFiles/Images/Mermer/bruno_perla.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 35, Title = "Rustik Bej", ImageFileUrl = "/UserFiles/Images/Mermer/rustik_bej.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 35, Title = "Royal Violet", ImageFileUrl = "/UserFiles/Images/Mermer/royal_violet.jpg" });

            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Amasya Bej", ImageFileUrl = "/UserFiles/Images/Mermer/amasya_bej.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Burdur Bej", ImageFileUrl = "/UserFiles/Images/Mermer/burdur_bej.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Classic Gümüş", ImageFileUrl = "/UserFiles/Images/Mermer/classic_gumus.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Elmalı Bej", ImageFileUrl = "/UserFiles/Images/Mermer/elmali_bej.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Kütahya Siyah", ImageFileUrl = "/UserFiles/Images/Mermer/kutahya_siyah.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Leopar", ImageFileUrl = "/UserFiles/Images/Mermer/leopar.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "Maroon Marinace", ImageFileUrl = "/UserFiles/Images/Mermer/maroon_marinace.jpg" });

            return View(model);
        }

        public ActionResult Onyx()
        {
            ViewBag.MetaTitle = "Onyx - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo=1, Title = "White Onyx", ImageFileUrl = "/UserFiles/Images/Onyx/white_onyx.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo=2, Title = "Bal Onyx",    ImageFileUrl = "/UserFiles/Images/Onyx/bal_onyx.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo=3, Title = "Green Onyx", ImageFileUrl = "/UserFiles/Images/Onyx/green_onyx.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo=4, Title = "Orange Onyx", ImageFileUrl = "/UserFiles/Images/Onyx/orange_onyx.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo=5, Title = "Pink Onyx", ImageFileUrl = "/UserFiles/Images/Onyx/pink_onyx.jpg" });

            return View(model);
        }

        public ActionResult Cimstone()
        {
            ViewBag.MetaTitle = "Çimstone - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();


            model.ProductList.Add(new Product() { TypeId = 1, Title = "100 - Hierapolis", ImageFileUrl = "/UserFiles/Images/Cimstone/100_hierapolis.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "147 - Recife", ImageFileUrl = "/UserFiles/Images/Cimstone/147_recife.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "170 - Etrna", ImageFileUrl = "/UserFiles/Images/Cimstone/170_etrna.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "175 - Keops", ImageFileUrl = "/UserFiles/Images/Cimstone/175_keops.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "220 - Artemis", ImageFileUrl = "/UserFiles/Images/Cimstone/220_artemis.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "306 - Oasis", ImageFileUrl = "/UserFiles/Images/Cimstone/306_oasis.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "328 - Nevers", ImageFileUrl = "/UserFiles/Images/Cimstone/328_nevers.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "332 - Lapaz", ImageFileUrl = "/UserFiles/Images/Cimstone/332_lapaz.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "345 - Lebedos", ImageFileUrl = "/UserFiles/Images/Cimstone/345_lebedos.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "402 - Arcadia", ImageFileUrl = "/UserFiles/Images/Cimstone/402_arcadia.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "422 - Riviera", ImageFileUrl = "/UserFiles/Images/Cimstone/422_riviera.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "456 - Hermes", ImageFileUrl = "/UserFiles/Images/Cimstone/465_hermes.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "470 - Fuga", ImageFileUrl = "/UserFiles/Images/Cimstone/470_fuga.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "560 - Alpino", ImageFileUrl = "/UserFiles/Images/Cimstone/560_alpino.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "580 - Kromit", ImageFileUrl = "/UserFiles/Images/Cimstone/580_kromit.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "614 - Mirat", ImageFileUrl = "/UserFiles/Images/Cimstone/614_mirat.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "645 - Boreas", ImageFileUrl = "/UserFiles/Images/Cimstone/645_boreas.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "725 - Mora", ImageFileUrl = "/UserFiles/Images/Cimstone/725_mora.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "759 - Savana", ImageFileUrl = "/UserFiles/Images/Cimstone/759_savana.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "796 - Sines", ImageFileUrl = "/UserFiles/Images/Cimstone/796_sines.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "811 - Elvas", ImageFileUrl = "/UserFiles/Images/Cimstone/811_elvas.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "814 - Caldera", ImageFileUrl = "/UserFiles/Images/Cimstone/814_caldera.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "815 - Smyrna", ImageFileUrl = "/UserFiles/Images/Cimstone/815_smyrna.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "870 - Tundra", ImageFileUrl = "/UserFiles/Images/Cimstone/870_tundra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "875 - Linen", ImageFileUrl = "/UserFiles/Images/Cimstone/875_linen.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "880 - Toros", ImageFileUrl = "/UserFiles/Images/Cimstone/880_toros.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "890 - Terra", ImageFileUrl = "/UserFiles/Images/Cimstone/890_terra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "900 - Lapland", ImageFileUrl = "/UserFiles/Images/Cimstone/900_lapland.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "911 - Gharma", ImageFileUrl = "/UserFiles/Images/Cimstone/911_gharma.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "912 - Troas", ImageFileUrl = "/UserFiles/Images/Cimstone/912_troas.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "925 - Nebula", ImageFileUrl = "/UserFiles/Images/Cimstone/925_nebula.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "930 - Ares", ImageFileUrl = "/UserFiles/Images/Cimstone/930_ares.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "935 - Versilia", ImageFileUrl = "/UserFiles/Images/Cimstone/935_versilia.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "936 - Olympos", ImageFileUrl = "/UserFiles/Images/Cimstone/936_olympos.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "955 - Barents", ImageFileUrl = "/UserFiles/Images/Cimstone/955_barents.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "975 - Palmira", ImageFileUrl = "/UserFiles/Images/Cimstone/975_palmira.jpg" });
            //model.ProductList.Add(new Product() { TypeId = 1, Title = "985 - Efes", ImageFileUrl = "/UserFiles/Images/Cimstone/985_efes.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "990 - Sineda", ImageFileUrl = "/UserFiles/Images/Cimstone/990_sineda.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "995 - Nephila", ImageFileUrl = "/UserFiles/Images/Cimstone/995_nephila.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, Title = "997 - Carbone", ImageFileUrl = "/UserFiles/Images/Cimstone/997_carbone.jpg" });

            return View(model);
        }

        public ActionResult Neolith()
        {
            ViewBag.MetaTitle = "Neolith - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Arctic White", ImageFileUrl = "/UserFiles/Images/Neolith/arctic_white.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Arena", ImageFileUrl = "/UserFiles/Images/Neolith/arena.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Aspen Grey", ImageFileUrl = "/UserFiles/Images/Neolith/aspen_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Avorio", ImageFileUrl = "/UserFiles/Images/Neolith/avorio.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Barro", ImageFileUrl = "/UserFiles/Images/Neolith/barro.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Basalt Black", ImageFileUrl = "/UserFiles/Images/Neolith/basalt_black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Basalt Grey", ImageFileUrl = "/UserFiles/Images/Neolith/basalt_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Beton", ImageFileUrl = "/UserFiles/Images/Neolith/beton.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco_carrara", ImageFileUrl = "/UserFiles/Images/Neolith/blanco_carrara.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Calacatta C01", ImageFileUrl = "/UserFiles/Images/Neolith/calacatta-c01.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Calacatta C01R", ImageFileUrl = "/UserFiles/Images/Neolith/calacatta-c01r.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Calacatta Gold CG01", ImageFileUrl = "/UserFiles/Images/Neolith/calacatta_gold_cg01.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Calacatta Gold CG01R", ImageFileUrl = "/UserFiles/Images/Neolith/calacatta_gold_cg01r.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Calatorao", ImageFileUrl = "/UserFiles/Images/Neolith/calatorao.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Cement", ImageFileUrl = "/UserFiles/Images/Neolith/cement.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Concrete Taupe", ImageFileUrl = "/UserFiles/Images/Neolith/concrete_taupe.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Estatuario E01", ImageFileUrl = "/UserFiles/Images/Neolith/estatuario-e01.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Estatuario E01R", ImageFileUrl = "/UserFiles/Images/Neolith/estatuario-e01r.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iron Copper", ImageFileUrl = "/UserFiles/Images/Neolith/iron_copper.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iron Corten", ImageFileUrl = "/UserFiles/Images/Neolith/iron_corten.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iron Frost", ImageFileUrl = "/UserFiles/Images/Neolith/iron_frost.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iron Grey", ImageFileUrl = "/UserFiles/Images/Neolith/iron_grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iron Moss", ImageFileUrl = "/UserFiles/Images/Neolith/iron_moss.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Krater", ImageFileUrl = "/UserFiles/Images/Neolith/krater.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "La Boheme B01", ImageFileUrl = "/UserFiles/Images/Neolith/la_boheme_b01.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "La Boheme B02", ImageFileUrl = "/UserFiles/Images/Neolith/la_boheme_b02.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Mar Del Plata", ImageFileUrl = "/UserFiles/Images/Neolith/mar_del_plata.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Mirage", ImageFileUrl = "/UserFiles/Images/Neolith/mirage.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Mont Blanc", ImageFileUrl = "/UserFiles/Images/Neolith/mont_blanc.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Nero Marquina", ImageFileUrl = "/UserFiles/Images/Neolith/nero_marquina.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Nero Zimbabwe", ImageFileUrl = "/UserFiles/Images/Neolith/nero_zimbabwe.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "New York", ImageFileUrl = "/UserFiles/Images/Neolith/newyork.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Phedra", ImageFileUrl = "/UserFiles/Images/Neolith/phedra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pierre Bleue", ImageFileUrl = "/UserFiles/Images/Neolith/pierre_bleue.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pietra Di Luna", ImageFileUrl = "/UserFiles/Images/Neolith/pietra_di_luna.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pietra Di Osso", ImageFileUrl = "/UserFiles/Images/Neolith/pietra_di_osso.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pietra Di Piomb", ImageFileUrl = "/UserFiles/Images/Neolith/pietra_di_piomb.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pulpis", ImageFileUrl = "/UserFiles/Images/Neolith/pulpis.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Retrostone", ImageFileUrl = "/UserFiles/Images/Neolith/retrostone.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Sofia Cuprum", ImageFileUrl = "/UserFiles/Images/Neolith/sofia_cuprum.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Steel Marengo", ImageFileUrl = "/UserFiles/Images/Neolith/steel_marengo.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Strata Argentum", ImageFileUrl = "/UserFiles/Images/Neolith/strata_argentum.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Zaha Stone", ImageFileUrl = "/UserFiles/Images/Neolith/zaha_stone.jpg" });

            return View(model);
        }

        public ActionResult Dekton()
        {
            ViewBag.MetaTitle = "Dekton - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();


            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Aldem", ImageFileUrl = "/UserFiles/Images/Dekton/Aldem.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Aura", ImageFileUrl = "/UserFiles/Images/Dekton/Aura.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanc Concrete", ImageFileUrl = "/UserFiles/Images/Dekton/Blanc_Concrete.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blaze", ImageFileUrl = "/UserFiles/Images/Dekton/Blaze.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Borea", ImageFileUrl = "/UserFiles/Images/Dekton/Borea.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Danae", ImageFileUrl = "/UserFiles/Images/Dekton/Danae.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Domoos", ImageFileUrl = "/UserFiles/Images/Dekton/Domoos.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Edora", ImageFileUrl = "/UserFiles/Images/Dekton/Edora.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Entzo", ImageFileUrl = "/UserFiles/Images/Dekton/Entzo.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Fiord", ImageFileUrl = "/UserFiles/Images/Dekton/Fiord.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Gada", ImageFileUrl = "/UserFiles/Images/Dekton/Gada.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Galema", ImageFileUrl = "/UserFiles/Images/Dekton/Galema.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Glacier", ImageFileUrl = "/UserFiles/Images/Dekton/Glacier.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Halo", ImageFileUrl = "/UserFiles/Images/Dekton/Halo.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Irok", ImageFileUrl = "/UserFiles/Images/Dekton/Irok.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Kadum", ImageFileUrl = "/UserFiles/Images/Dekton/Kadum.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Kairos", ImageFileUrl = "/UserFiles/Images/Dekton/Kairos.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Kelya", ImageFileUrl = "/UserFiles/Images/Dekton/Kelya.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Keon", ImageFileUrl = "/UserFiles/Images/Dekton/Keon.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Keranium", ImageFileUrl = "/UserFiles/Images/Dekton/Keranium.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Korus", ImageFileUrl = "/UserFiles/Images/Dekton/Korus.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Lumina", ImageFileUrl = "/UserFiles/Images/Dekton/Lumina.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Makai", ImageFileUrl = "/UserFiles/Images/Dekton/Makai.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Manhattan", ImageFileUrl = "/UserFiles/Images/Dekton/Manhattan.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Natura", ImageFileUrl = "/UserFiles/Images/Dekton/Natura.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Nayla", ImageFileUrl = "/UserFiles/Images/Dekton/Nayla.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Nilium", ImageFileUrl = "/UserFiles/Images/Dekton/Nilium.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Opera", ImageFileUrl = "/UserFiles/Images/Dekton/Opera.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Orix", ImageFileUrl = "/UserFiles/Images/Dekton/Orix.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Qatar", ImageFileUrl = "/UserFiles/Images/Dekton/Qatar.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Radium", ImageFileUrl = "/UserFiles/Images/Dekton/Radium.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Sirius", ImageFileUrl = "/UserFiles/Images/Dekton/Sirius.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Sirocco", ImageFileUrl = "/UserFiles/Images/Dekton/Sirocco.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Spectra", ImageFileUrl = "/UserFiles/Images/Dekton/Spectra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Splendor", ImageFileUrl = "/UserFiles/Images/Dekton/Splendor.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Strato", ImageFileUrl = "/UserFiles/Images/Dekton/Strato.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Trilium", ImageFileUrl = "/UserFiles/Images/Dekton/Trilium.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Tundra", ImageFileUrl = "/UserFiles/Images/Dekton/Tundra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Valterra", ImageFileUrl = "/UserFiles/Images/Dekton/Valterra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Vegha", ImageFileUrl = "/UserFiles/Images/Dekton/Vegha.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Ventus", ImageFileUrl = "/UserFiles/Images/Dekton/Ventus.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Vienna", ImageFileUrl = "/UserFiles/Images/Dekton/Vienna.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Zenith", ImageFileUrl = "/UserFiles/Images/Dekton/Zenith.jpg" });

            return View(model);
        }

        public ActionResult Silestone()
        {
            ViewBag.MetaTitle = "Silestone - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();


            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Altair 15", ImageFileUrl = "/UserFiles/Images/Silestone/Altair_15.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Amazon", ImageFileUrl = "/UserFiles/Images/Silestone/Amazon.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Arden Blue", ImageFileUrl = "/UserFiles/Images/Silestone/Arden_Blue.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Ariel", ImageFileUrl = "/UserFiles/Images/Silestone/Ariel.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Bianco Rivers", ImageFileUrl = "/UserFiles/Images/Silestone/Bianco_Rivers.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco Zeus", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_Zeus.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco Capri", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_Capri.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco City", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_City.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco Maple 14", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_Maple_14.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco Norte", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_Norte.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco Orion", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_Orion.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Blanco Stellar", ImageFileUrl = "/UserFiles/Images/Silestone/Blanco_Stellar.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Calypso", ImageFileUrl = "/UserFiles/Images/Silestone/Calypso.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Cemento Spa", ImageFileUrl = "/UserFiles/Images/Silestone/Cemento_Spa.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Charcoal Soapstone", ImageFileUrl = "/UserFiles/Images/Silestone/Charcoal_Soapstone.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Coral Clay", ImageFileUrl = "/UserFiles/Images/Silestone/Coral_Clay.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Crema Minerva 16", ImageFileUrl = "/UserFiles/Images/Silestone/Crema_Minerva_16.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Cygnus", ImageFileUrl = "/UserFiles/Images/Silestone/Cygnus.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Daria", ImageFileUrl = "/UserFiles/Images/Silestone/Daria.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Doradus", ImageFileUrl = "/UserFiles/Images/Silestone/Doradus.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Eternal Calacatta Gold", ImageFileUrl = "/UserFiles/Images/Silestone/Eternal_Calacatta_Gold.png" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Eternal Marquina", ImageFileUrl = "/UserFiles/Images/Silestone/Eternal_Marquina.png" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Eternal Serena", ImageFileUrl = "/UserFiles/Images/Silestone/Eternal_Serena.png" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Eternal Statuario", ImageFileUrl = "/UserFiles/Images/Silestone/Eternal_Statuario.png" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Gris Expo", ImageFileUrl = "/UserFiles/Images/Silestone/Gris_Expo.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Haiku", ImageFileUrl = "/UserFiles/Images/Silestone/Haiku.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iconic Black", ImageFileUrl = "/UserFiles/Images/Silestone/Iconic_Black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iconic White", ImageFileUrl = "/UserFiles/Images/Silestone/Iconic_White.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Iron Bark", ImageFileUrl = "/UserFiles/Images/Silestone/Iron_Bark.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Kensho", ImageFileUrl = "/UserFiles/Images/Silestone/Kensho.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Lagoon", ImageFileUrl = "/UserFiles/Images/Silestone/Lagoon.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Lyra", ImageFileUrl = "/UserFiles/Images/Silestone/Lyra.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Marengo", ImageFileUrl = "/UserFiles/Images/Silestone/Marengo.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Merope", ImageFileUrl = "/UserFiles/Images/Silestone/Merope.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Negro Stellar", ImageFileUrl = "/UserFiles/Images/Silestone/Negro_Stellar.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Negro Tebas", ImageFileUrl = "/UserFiles/Images/Silestone/Negro_Tebas.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Noka", ImageFileUrl = "/UserFiles/Images/Silestone/Noka.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Nymbus", ImageFileUrl = "/UserFiles/Images/Silestone/Nymbus.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pacific", ImageFileUrl = "/UserFiles/Images/Silestone/Pacific.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pearl Jasmine", ImageFileUrl = "/UserFiles/Images/Silestone/Pearl_Jasmine.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Pulsar", ImageFileUrl = "/UserFiles/Images/Silestone/Pulsar.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Rosso Monza", ImageFileUrl = "/UserFiles/Images/Silestone/Rosso_Monza.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Rougui", ImageFileUrl = "/UserFiles/Images/Silestone/Rougui.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Royal Reef", ImageFileUrl = "/UserFiles/Images/Silestone/Royal_Reef.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Snowy Ibiza", ImageFileUrl = "/UserFiles/Images/Silestone/Snowy_Ibiza.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Tigris Sand", ImageFileUrl = "/UserFiles/Images/Silestone/Tigris_Sand.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Unsui", ImageFileUrl = "/UserFiles/Images/Silestone/Unsui.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "White Storm", ImageFileUrl = "/UserFiles/Images/Silestone/White_Storm.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "White Arabesque", ImageFileUrl = "/UserFiles/Images/Silestone/White_Arabesque.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Yukon", ImageFileUrl = "/UserFiles/Images/Silestone/Yukon.jpg" });


            return View(model);
        }

        public ActionResult Infinity()
        {
            ViewBag.MetaTitle = "Infinity - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "CE02 Concrete Grey", ImageFileUrl = "/UserFiles/Images/Infinity/CE02_Concrete_Grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "CE03 Concrete Black", ImageFileUrl = "/UserFiles/Images/Infinity/CE03_Concrete_Black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MA03 Terrazzo Grey", ImageFileUrl = "/UserFiles/Images/Infinity/MA03_Terrazzo_Grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB02 Renoir", ImageFileUrl = "/UserFiles/Images/Infinity/MB02_Renoir.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB03 Classic Statuario", ImageFileUrl = "/UserFiles/Images/Infinity/MB03_Classic_Statuario.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB04 Extra Statuario", ImageFileUrl = "/UserFiles/Images/Infinity/MB04_Extra_Statuario.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB06 Calacatta Oro", ImageFileUrl = "/UserFiles/Images/Infinity/MB06_Calacatta_Oro.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB07 Calacatta Lincoln", ImageFileUrl = "/UserFiles/Images/Infinity/MB07_Calacatta_Lincoln.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB08 Pulpis Brown", ImageFileUrl = "/UserFiles/Images/Infinity/MB08_Pulpis_Brown.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB09 Pietra Grey", ImageFileUrl = "/UserFiles/Images/Infinity/MB09_Pietra_Grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB10 Sahara Noir", ImageFileUrl = "/UserFiles/Images/Infinity/MB10_Sahara_Noir.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB11 Nero Marquina", ImageFileUrl = "/UserFiles/Images/Infinity/MB11_Nero_Marquina.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB13 Tundra Select", ImageFileUrl = "/UserFiles/Images/Infinity/MB13_Tundra_Select.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB14 Precious Sodalite", ImageFileUrl = "/UserFiles/Images/Infinity/MB14_Precious_Sodalite.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB15 Verde France", ImageFileUrl = "/UserFiles/Images/Infinity/MB15_Verde_France.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "MB16 Calacatta Magnifico", ImageFileUrl = "/UserFiles/Images/Infinity/MB16_Calacatta_Magnifico.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "ME01 Metal Silver", ImageFileUrl = "/UserFiles/Images/Infinity/ME01_Metal_Silver.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "ME02 Metal Dark", ImageFileUrl = "/UserFiles/Images/Infinity/ME02_Metal_Dark.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "ME03 Metal Corten", ImageFileUrl = "/UserFiles/Images/Infinity/ME03_Metal_Corten.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "OC01 Crystal Ice", ImageFileUrl = "/UserFiles/Images/Infinity/OC01_Crystal_Ice.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "OC03 Ocean Blue", ImageFileUrl = "/UserFiles/Images/Infinity/OC03_Ocean_Blue.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "RE03 Total Grey", ImageFileUrl = "/UserFiles/Images/Infinity/RE03_Total_Grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "RE04 Total Black", ImageFileUrl = "/UserFiles/Images/Infinity/RE04_Total_Black.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "SC01 Absolute White", ImageFileUrl = "/UserFiles/Images/Infinity/SC01_Absolute_White.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "SE01 Chianca Di Ostuni", ImageFileUrl = "/UserFiles/Images/Infinity/SE01_Chianca_di_Ostuni.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "SE05 Nero Granite", ImageFileUrl = "/UserFiles/Images/Infinity/SE05_Nero_Granite.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "SE06 Travertino Grey", ImageFileUrl = "/UserFiles/Images/Infinity/SE06_Travertino_Grey.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "SE07 Buxy Select", ImageFileUrl = "/UserFiles/Images/Infinity/SE07_Buxy_Select.jpg" });
            return View(model);
        }

        public ActionResult Belenco()
        {
            ViewBag.MetaTitle = "Belenco - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();


            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "1110 - Iceberg", ImageFileUrl = "/UserFiles/Images/Belenco/1110_iceberg.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "1227 - Pixie Wings", ImageFileUrl = "/UserFiles/Images/Belenco/1227_pixie_wings.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "2110 - Angel White", ImageFileUrl = "/UserFiles/Images/Belenco/2110_angel_white.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "2214 - Teos", ImageFileUrl = "/UserFiles/Images/Belenco/2214_teos.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "2254 - Aurora", ImageFileUrl = "/UserFiles/Images/Belenco/2254_aurora.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "3113 - Daphne Crack", ImageFileUrl = "/UserFiles/Images/Belenco/3113_daphne_crack.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "3223 - Lumiere", ImageFileUrl = "/UserFiles/Images/Belenco/3223_lumiere.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "3333 - Boletus", ImageFileUrl = "/UserFiles/Images/Belenco/3333_boletus.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "3555 - Parma", ImageFileUrl = "/UserFiles/Images/Belenco/3555_parma.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "3618 - Olympos", ImageFileUrl = "/UserFiles/Images/Belenco/3618_olympos.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4043 - Aizano", ImageFileUrl = "/UserFiles/Images/Belenco/4043_aizano.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4123 - Kashmera White", ImageFileUrl = "/UserFiles/Images/Belenco/4123_kashmera_white.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4227 - Fairy White", ImageFileUrl = "/UserFiles/Images/Belenco/4227_fairy_white.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4262 - Kristella White", ImageFileUrl = "/UserFiles/Images/Belenco/4262_kristella_white.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4444 - Sahara Beige", ImageFileUrl = "/UserFiles/Images/Belenco/4444_sahara_beige.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4458 - Chakra Beige", ImageFileUrl = "/UserFiles/Images/Belenco/4458_chakra_beige.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4524 - Laluna", ImageFileUrl = "/UserFiles/Images/Belenco/4524_laluna.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "4558 - Babilon", ImageFileUrl = "/UserFiles/Images/Belenco/4558_babilon.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "5050 - Forza Fume", ImageFileUrl = "/UserFiles/Images/Belenco/5050_forza_fume.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "5114 - Carola", ImageFileUrl = "/UserFiles/Images/Belenco/5114_carola.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "5139 - Juliet White", ImageFileUrl = "/UserFiles/Images/Belenco/5139_juliet_white.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "5250 - Elixir White", ImageFileUrl = "/UserFiles/Images/Belenco/5250_elixir_white.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "5329 - Mocca Mousse", ImageFileUrl = "/UserFiles/Images/Belenco/5329_mocca_mousse.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "5751 - Gala Black", ImageFileUrl = "/UserFiles/Images/Belenco/5751_gala_black.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "6523 - Starlight", ImageFileUrl = "/UserFiles/Images/Belenco/6523_starlight.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "6656 - Lisbon", ImageFileUrl = "/UserFiles/Images/Belenco/6656_lisbon.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "7119 - Calacatta Venatino", ImageFileUrl = "/UserFiles/Images/Belenco/7119_calacatta_venatino.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "7537 - Metropol Grey", ImageFileUrl = "/UserFiles/Images/Belenco/7537_metropol_grey.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "7543 - Montana", ImageFileUrl = "/UserFiles/Images/Belenco/7543_montana.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "8113 - Anemon", ImageFileUrl = "/UserFiles/Images/Belenco/8113_anemon.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "8119 - Calacatta Verona", ImageFileUrl = "/UserFiles/Images/Belenco/8119_calacatta_verona.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "8224 - Interstellar", ImageFileUrl = "/UserFiles/Images/Belenco/8224_interstellar.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "8727 - Spa Black", ImageFileUrl = "/UserFiles/Images/Belenco/8727_spa_black.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "8765 - Volcano Black", ImageFileUrl = "/UserFiles/Images/Belenco/8765_volcano_black.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "9113 - Alinda", ImageFileUrl = "/UserFiles/Images/Belenco/9113_alinda.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "9119 - Calacatta Veneto", ImageFileUrl = "/UserFiles/Images/Belenco/9119_calacatta_veneto.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "9219 - Marquina Tierra", ImageFileUrl = "/UserFiles/Images/Belenco/9219_marquina_tierra.jpeg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "9719 - Marquina Lavagna", ImageFileUrl = "/UserFiles/Images/Belenco/9719_marquina_lavagna.jpeg" });

            return View(model);
        }


        [Route("granit-mermer-yakma")]
        public ActionResult GranitMermerYakma()
        {
            ViewBag.MetaTitle = "Granit Mermer Yakma - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";


            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Granit Mermer Yakma - 1", ImageFileUrl = "/UserFiles/Images/UretimYakma/1.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Granit Mermer Yakma - 2", ImageFileUrl = "/UserFiles/Images/UretimYakma/2.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Granit Mermer Yakma - 3", ImageFileUrl = "/UserFiles/Images/UretimYakma/3.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Granit Mermer Yakma - 4", ImageFileUrl = "/UserFiles/Images/UretimYakma/4.jpg" });


            return View(model);
        }

        [Route("patinato")]
        public ActionResult Patinato()
        {
            ViewBag.MetaTitle = "Patino - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";


            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();

            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 1", ImageFileUrl = "/UserFiles/Images/UretimPatinato/1.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 2", ImageFileUrl = "/UserFiles/Images/UretimPatinato/2.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 3", ImageFileUrl = "/UserFiles/Images/UretimPatinato/3.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 4", ImageFileUrl = "/UserFiles/Images/UretimPatinato/4.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 5", ImageFileUrl = "/UserFiles/Images/UretimPatinato/5.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 6", ImageFileUrl = "/UserFiles/Images/UretimPatinato/6.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 7", ImageFileUrl = "/UserFiles/Images/UretimPatinato/7.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 8", ImageFileUrl = "/UserFiles/Images/UretimPatinato/8.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 9", ImageFileUrl = "/UserFiles/Images/UretimPatinato/9.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 10", ImageFileUrl = "/UserFiles/Images/UretimPatinato/10.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 11", ImageFileUrl = "/UserFiles/Images/UretimPatinato/11.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 12", ImageFileUrl = "/UserFiles/Images/UretimPatinato/12.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 13", ImageFileUrl = "/UserFiles/Images/UretimPatinato/13.jpg" });
            model.ProductList.Add(new Product() { TypeId = 1, OrderNo = 1, Title = "Patinato Uygulama - 14", ImageFileUrl = "/UserFiles/Images/UretimPatinato/14.jpg" });


            return View(model);
        }

        public ActionResult TumUrunler()
        {
            return View();
        }


        [Route("mermer-masa")]
        public ActionResult MermerMasa()
        {
            ContentVM model = new ContentVM();

            model.ProductList = new List<Product>();


            for (int i = 1; i <= 49; i++)
            {
                model.ProductList.Add(new Product() { TypeId = 4, OrderNo = i, Title = "Model No: " + i.ToString(), ImageFileUrl = String.Format("/UserFiles/Images/MermerMasa/{0}.jpg",i) });
            }


            return View(model);
        }

        public ActionResult Uygulamalar()
        {
            ViewBag.MetaTitle = "Uygulamalar - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            return View();
        }
  


        [Route("bize-ulasin")]
        public ActionResult BizeUlasin()
        {
            ViewBag.MetaTitle = "Bize Ulaşın - Zirve Doğaltaş Şekerpınar";
            ViewBag.MetaDescription = "Zirve Doğaltaş; 20 yıllık tecrübesiyle sektörün en güçlü firmalarından olan firmamız granit, mermer, belenco, çimstone, dekton, infinity, silestone, neolith ve porselen tezgah üreten doğaltaş uygulama firmasıdır.";
            ViewBag.MetaTags = "zirve, zirve doğaltaş, nail özbay, zirve nail, zirve nail özbay, granit, mermer, belenco, onyx, çimstone, dekton, infinity, silestone, neolith, porselen tezgah";

            return View();
        }

       
    }
}