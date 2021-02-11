CREATE TABLE shopList
(
    Id int IDENTITY PRIMARY KEY,
    NomShop nvarchar(30),
    AdressShop nvarchar(50),
    ImgShop nvarchar(200)
)

INSERT shopList  
   (NomShop, AdressShop, ImgShop)  
VALUES  
   ('Maison Lejaby', '24 rue de Sèvres, Paris', 'https://www.maisonlejaby.com/soldes/soldes/soldes.html?gclid=CjwKCAiAsOmABhAwEiwAEBR0Znl8PTcP1K-3fj0peLb9N34AgOmoAF0yr4KEjM-IFhHqeeoAl9_GixoCKuQQAvD_BwE'),
   ('Les studios Français', '14 cité bergère, Paris ', 'https://lesstudiosfrancais.com/'),
   ('La petite française', '18 rue du Caire, Paris', 'https://www.la-petite-francaise.com/'),
   ('Le slip Français', '7 rue Charonne, Paris', 'https://www.google.com/search?client=firefox-b-d&q=le+slip+francais');