-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 13, 2023 at 09:38 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `booksystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `LockoutEndDateUtc` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `LockoutEndDateUtc`) VALUES
('df786f11-3d69-46e1-90c9-360ed219ecff', 'johnrobert.delinila@dict.gov.ph', NULL, 'johnrobert.delinila@dict.gov.ph', NULL, b'0', 'AD3zwEn1x3myQ4Tu8u2NSMcaHisYJR07ZNbUpL7J1siGgjflj6eTpk4yK0On6aURMg==', 'ce970866-050f-46fd-9e22-7f5e8ff31984', NULL, NULL, b'0', b'0', NULL, b'1', 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `Id` int(11) NOT NULL,
  `PublishingHouseId` int(11) NOT NULL,
  `SupplierId` int(11) NOT NULL,
  `ISBN` longtext DEFAULT NULL,
  `Name` longtext DEFAULT NULL,
  `Author` longtext DEFAULT NULL,
  `TypeId` int(11) NOT NULL,
  `Genre` longtext DEFAULT NULL,
  `PublishingYear` int(11) NOT NULL,
  `Pages` int(11) NOT NULL,
  `CoverType` longtext DEFAULT NULL,
  `BookPrice` int(11) NOT NULL,
  `SupplyDate` longtext DEFAULT NULL,
  `Rest` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`Id`, `PublishingHouseId`, `SupplierId`, `ISBN`, `Name`, `Author`, `TypeId`, `Genre`, `PublishingYear`, `Pages`, `CoverType`, `BookPrice`, `SupplyDate`, `Rest`) VALUES
(1, 1, 1, 'as21341243', 'adsfasdfasdfa', 'asdfasdf', 1, 'asdfasdf', 2421, 2, 'asdfa', 21, 'asdf', 213);

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `Id` int(11) NOT NULL,
  `Name` longtext DEFAULT NULL,
  `Birthday` longtext DEFAULT NULL,
  `Address` longtext DEFAULT NULL,
  `Phone` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`Id`, `Name`, `Birthday`, `Address`, `Phone`) VALUES
(1, 'John Smith', '11.01.1998', '123 Main Street, Manila, Philippines', '+63 1234567890'),
(2, 'Jane Doe', '22.03.1985', '456 Elm Avenue, Cebu City, Philippines', '+63 9876543210'),
(3, 'Michael Johnson', '07.07.1990', '789 Oak Lane, Quezon City, Philippines', '+63 8765432109'),
(4, 'Maria Garcia', '15.09.1982', '321 Pine Road, Makati City, Philippines', '+63 7654321098'),
(5, 'David Lee', '30.05.1995', '555 Maple Street, Davao City, Philippines', '+63 6543210987'),
(6, 'Anna Reyes', '12.11.1988', '777 Birch Avenue, Pasig City, Philippines', '+63 5432109876'),
(7, 'Robert Santos', '03.04.1993', '222 Cedar Lane, Mandaluyong City, Philippines', '+63 4321098765'),
(8, 'Linda Cruz', '17.08.1980', '888 Ash Street, Taguig City, Philippines', '+63 3210987654'),
(9, 'Joseph Lim', '26.12.1997', '999 Willow Road, Caloocan City, Philippines', '+63 2109876543'),
(10, 'Mary Torres', '09.06.1986', '444 Elm Street, Parañaque City, Philippines', '+63 1098765432');

-- --------------------------------------------------------

--
-- Table structure for table `delivery`
--

CREATE TABLE `delivery` (
  `Id` int(11) NOT NULL,
  `Name` longtext DEFAULT NULL,
  `Phone` longtext DEFAULT NULL,
  `Cost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `delivery`
--

INSERT INTO `delivery` (`Id`, `Name`, `Phone`, `Cost`) VALUES
(1, 'BoxBerry', '+63 800 222 8000', 201),
(2, 'Swift Delivery', '+63 877 123 4567', 150),
(3, 'Book Express', '+63 900 987 6543', 180),
(4, 'Bookworm Delivery', '+63 955 543 2109', 220),
(5, 'Speedy Books', '+63 933 654 3210', 190),
(6, 'Literary Logistics', '+63 977 876 5432', 205),
(7, 'Book Courier', '+63 922 345 6789', 175),
(8, 'Rapid Readers', '+63 988 987 6543', 195),
(9, 'Novel Dispatch', '+63 966 432 1098', 210),
(10, 'PageTurner Delivery', '+63 977 210 9876', 215);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Id` int(11) NOT NULL,
  `Name` longtext DEFAULT NULL,
  `Birthday` longtext DEFAULT NULL,
  `Address` longtext DEFAULT NULL,
  `Phone` longtext DEFAULT NULL,
  `Position` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`Id`, `Name`, `Birthday`, `Address`, `Phone`, `Position`) VALUES
(1, 'John Smith', '17.07.1963', '123 Main Street, Manila, Philippines', '+63 1234567890', 'Delivery Driver'),
(2, 'Jane Doe', '05.12.1978', '456 Elm Avenue, Cebu City, Philippines', '+63 9876543210', 'Dispatch Coordinator'),
(3, 'Michael Johnson', '28.03.1985', '789 Oak Lane, Quezon City, Philippines', '+63 8765432109', 'Operations Manager'),
(4, 'Maria Garcia', '10.09.1990', '321 Pine Road, Makati City, Philippines', '+63 7654321098', 'Customer Service Representative'),
(5, 'David Lee', '21.06.1982', '555 Maple Street, Davao City, Philippines', '+63 6543210987', 'Warehouse Supervisor'),
(6, 'Anna Reyes', '12.02.1975', '777 Birch Avenue, Pasig City, Philippines', '+63 5432109876', 'Logistics Coordinator'),
(7, 'Robert Santos', '08.11.1987', '222 Cedar Lane, Mandaluyong City, Philippines', '+63 4321098765', 'Fleet Manager'),
(8, 'Linda Cruz', '19.09.1993', '888 Ash Street, Taguig City, Philippines', '+63 3210987654', 'Route Planner'),
(9, 'Joseph Lim', '03.04.1980', '999 Willow Road, Caloocan City, Philippines', '+63 2109876543', 'Operations Supervisor'),
(10, 'Mary Torres', '14.01.1988', '444 Elm Street, Parañaque City, Philippines', '+63 1098765432', 'Delivery Coordinator');

-- --------------------------------------------------------

--
-- Table structure for table `publishinghouse`
--

CREATE TABLE `publishinghouse` (
  `Id` int(11) NOT NULL,
  `Name` longtext DEFAULT NULL,
  `Address` longtext DEFAULT NULL,
  `Phone` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `publishinghouse`
--

INSERT INTO `publishinghouse` (`Id`, `Name`, `Address`, `Phone`) VALUES
(1, 'ABC Publishing', '123 Main Street, Manila, Philippines', '+63 1234567890'),
(2, 'XYZ Publishers', '456 Elm Avenue, Cebu City, Philippines', '+63 9876543210'),
(3, 'Sunrise Books', '789 Oak Lane, Quezon City, Philippines', '+63 8765432109'),
(4, 'Golden Publishing', '321 Pine Road, Makati City, Philippines', '+63 7654321098'),
(5, 'Rainbow Press', '555 Maple Street, Davao City, Philippines', '+63 6543210987'),
(6, 'Silver Publications', '777 Birch Avenue, Pasig City, Philippines', '+63 5432109876'),
(7, 'Globe Books', '222 Cedar Lane, Mandaluyong City, Philippines', '+63 4321098765'),
(8, 'Star Publishing', '888 Ash Street, Taguig City, Philippines', '+63 3210987654'),
(9, 'Pacific Publishers', '999 Willow Road, Caloocan City, Philippines', '+63 2109876543'),
(10, 'Sunset Books', '444 Elm Street, Parañaque City, Philippines', '+63 1098765432');

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE `purchase` (
  `Id` int(11) NOT NULL,
  `EmployeeId` int(11) NOT NULL,
  `ClientId` int(11) NOT NULL,
  `DeliveryId` int(11) NOT NULL,
  `Ordate` longtext DEFAULT NULL,
  `Address` longtext DEFAULT NULL,
  `Delcost` int(11) NOT NULL,
  `Saledate` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`Id`, `EmployeeId`, `ClientId`, `DeliveryId`, `Ordate`, `Address`, `Delcost`, `Saledate`) VALUES
(1, 1, 1, 1, '05.19.2023', 'San Fernando City La Union', 2500, '05.20.2023');

-- --------------------------------------------------------

--
-- Table structure for table `purchased`
--

CREATE TABLE `purchased` (
  `Id` int(11) NOT NULL,
  `PurchaseId` int(11) NOT NULL,
  `BookId` int(11) NOT NULL,
  `OrderPrice` int(11) NOT NULL,
  `Number` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purchased`
--

INSERT INTO `purchased` (`Id`, `PurchaseId`, `BookId`, `OrderPrice`, `Number`) VALUES
(1, 1, 1, 200, 18);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `Id` int(11) NOT NULL,
  `Name` longtext DEFAULT NULL,
  `ContactPerson` longtext DEFAULT NULL,
  `Position` longtext DEFAULT NULL,
  `Address` longtext DEFAULT NULL,
  `Phone` longtext DEFAULT NULL,
  `AboutCompany` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Id`, `Name`, `ContactPerson`, `Position`, `Address`, `Phone`, `AboutCompany`) VALUES
(1, 'ABC Books Supplier', 'John Doe', 'Sales Manager', '123 Main Street, Manila, Philippines', '+63 1234567890', 'ABC Books Supplier is a leading distributor of educational books in the Philippines, providing a wide range of textbooks, reference materials, and learning resources to schools and institutions.'),
(2, 'XYZ Publishers and Distributors', 'Jane Smith', 'Sales Representative', '456 Elm Avenue, Cebu City, Philippines', '+63 9876543210', 'XYZ Publishers and Distributors is a reputable supplier of fiction and non-fiction books, catering to various genres and interests. We pride ourselves on delivering high-quality books to bookstores and online retailers.'),
(3, 'Rainbow Bookstore', 'David Lee', 'Owner', '789 Oak Lane, Quezon City, Philippines', '+63 8765432109', 'Rainbow Bookstore is a local independent bookstore dedicated to promoting local authors and showcasing a diverse collection of books. We support the Philippine publishing industry by partnering with local publishers and authors.'),
(4, 'Sunrise Publishing House', 'Maria Garcia', 'Procurement Manager', '321 Pine Road, Makati City, Philippines', '+63 7654321098', 'Sunrise Publishing House is a well-established publishing company in the Philippines. We collaborate with local and international authors to produce high-quality books across various genres, including literature, history, and self-help.'),
(5, 'Golden Book Distributors', 'Michael Tan', 'Sales Executive', '555 Maple Street, Davao City, Philippines', '+63 6543210987', 'Golden Book Distributors is a reliable supplier of children\'s books and educational materials. We work closely with schools, libraries, and retailers to provide engaging and educational resources that inspire young readers.'),
(6, 'Silver Publications', 'Anna Reyes', 'Business Development Manager', '777 Birch Avenue, Pasig City, Philippines', '+63 5432109876', 'Silver Publications is a renowned publisher and distributor of academic and professional books. We specialize in delivering high-quality textbooks, research materials, and reference books to universities, colleges, and professionals in various fields.'),
(7, 'Globe Books and Stationery', 'Robert Santos', 'Operations Manager', '222 Cedar Lane, Mandaluyong City, Philippines', '+63 4321098765', 'Globe Books and Stationery offers a wide range of books, stationery items, and school supplies. We supply educational materials to schools, colleges, and offices, ensuring access to essential resources for learning and productivity.'),
(8, 'Star Publishing Company', 'Linda Cruz', 'Marketing Coordinator', '888 Ash Street, Taguig City, Philippines', '+63 3210987654', 'Star Publishing Company is a leading provider of academic books and reference materials for universities and libraries. We collaborate with renowned authors and scholars to publish authoritative and comprehensive resources.'),
(9, 'Pacific Books and More', 'Joseph Lim', 'Sales and Marketing Director', '999 Willow Road, Caloocan City, Philippines', '+63 2109876543', 'Pacific Books and More is a supplier of a wide range of books, from bestsellers to niche genres. We offer competitive prices and timely delivery, catering to the needs of bookstores, online retailers, and individual customers.'),
(10, 'Sunset Publishers', 'Mary Torres', 'Business Manager', '444 Elm Street, Parañaque City, Philippines', '+63 1098765432', 'Sunset Publishers is a publishing company committed to promoting local literature and supporting Filipino authors. We publish books across various genres, including fiction, poetry, and regional literature.');

-- --------------------------------------------------------

--
-- Table structure for table `type`
--

CREATE TABLE `type` (
  `Id` int(11) NOT NULL,
  `Category` longtext DEFAULT NULL,
  `Description` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `type`
--

INSERT INTO `type` (`Id`, `Category`, `Description`) VALUES
(1, 'Fiction', 'Novels and Stories'),
(2, 'Non-fiction', 'Biographies'),
(3, 'Thriller', 'Suspense and Action'),
(4, 'Romance', 'Love and Relationships'),
(5, 'Mystery', 'Detective and Crime'),
(6, 'Science Fiction', 'Fantasy and Futuristic'),
(7, 'Self-help', 'Personal Development'),
(8, 'History', 'Past Events and Civilizations'),
(9, 'Biography', 'Life Stories of Individuals'),
(10, 'Cooking', 'Recipes and Culinary Arts'),
(11, 'Sample course', 'jj');

-- --------------------------------------------------------

--
-- Table structure for table `__migrationhistory`
--

CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8 NOT NULL,
  `ContextKey` varchar(300) CHARACTER SET utf8 NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__migrationhistory`
--

INSERT INTO `__migrationhistory` (`MigrationId`, `ContextKey`, `Model`, `ProductVersion`) VALUES
('201905040815585_InitialCreate', 'BlackBooksApp.Migrations.Configuration', 0x1f8b0800000000000400ed1ddb6edcbaf1bd40ff41d06391e375929753637d0eec75d21a8d2fc82607ed53404bf45a8856daea127851f4cbfad04f3abf702851947817a9ebfa8200819797e17038331cce90a3dffff7ffe5af8fdbd0f901933488a353f7edd1b1ebc0c88bfd20da9cba7976ffd3cfeeafbffcf94fcb0ffef6d1f98db47b5fb4433da3f4d47dc8b2ddc962917a0f700bd2a36de025711adf67475ebc5d003f5ebc3b3efeebe2eddb0544205c04cb71969ff3280bb6b0fc817eaee2c883bb2c07e155ecc330adca51cdba84ea5c832d4c77c083a7ee7908bcefe771fc3d3ddbed8e2ece3eb9ce59180084c81a86f7ae03a228ce4086d03cf99ac27596c4d166bd430520fcb2df41d4ee1e8429acd03f699a9bcee4f85d319345d39180f2f2348bb79600dfbeaf48b3e0bb7722b05b930e11ef032272b62f665d1210d10e91cd75f8814e56615234e2698bd7e2a8f8fdc661aaded49c8018a6f8f7c659e5619627f03482799680f08d739bdf8581f70fb8ff127f87d1699487218d1c420fd53105a8e836897730c9f69fe17d85f2a5ef3a0bb6df82ef5877a3fae0095d46d9fb77ae738d06077721acd79e9afc3a8b13f83718c10464d0bf05590693a880014bea09a3736395d34c1f90b8fc3dce53d83eb41edc3adfedc200267de15caecfaf09042403083dd7b9028f9f60b4c91e4e5df4a7eb7c0c1ea14f4a2aa85fa300093fea942579eb20c5ffa30f7296670f7132fa3005f8be44475c948c4f9086e3fe0541d20fe35bb081693f10ab18ed1e0580d1275e689fdb24f0e00022b6bf40d23e3ac69f619a59227b0d7e049b5233e9158deb7c8661d90e95edf0e677c4b5f956ea6b348f24de7e8e4311086ef0ed0b4836b04034d6b55ac779e259219c780f20857e858514dfaac937bc33d188d235120c996a5bd488969522452a45eab13502525cb52d5258862408151522324da9800855254362b9680c03adb920b09ca5e5c0f57f352254634db391fa7e02d374fcfde9218e46988d526e74eaa5933a2432a3578744e83a4a56a5bf3ac854d5f3e549d375c9576dc611264f5f53ae206b5f1837890f93010c96eb7c7b076d0d3dadb8f4db8c45f990eed5b6768216a96fbc352162c73551da0c7cbb9e5b2441bea31cbf8ab16c9c0fdb5d18ef616f315e217b2ccafa42b98061800e39fb0114c214a78ea9367a44162fb63ee0f0a63808e13854512a1ccc14527583ab6a0dc1e819be4e50304203db1300e133296aa4528e9c582ba02769628b20114b2982a4528ea0582b20286932e299b3c38ea2daf8543b4fa71d8570a7e57e82bbbdbcdde4a08e58e741923df860ff6c54fcd467394a75f4d5cebcb02ad57727296d54b5a59c928eaf923aaba48ec4d8826f7c48ffaf4e34acad035e3c3406442701694c054b01211d5f0564560179ddcaba8d12a7010ede1fc89e696d95f38a4163b877520c4decc55231908eaf8a6156c5b08aa30c78d92d22fa186c3e993c3d6b35747617e7d92adeee40348206ef108a310eaaf2ea471173eda47a7084d552ed1455af2a47a90d50af4d9c8c6f265cc0d44b82ddc47bab9aa15b83f23c234be2f5264c7c96a6b11794a3cba3f21512ec843e44be6314e2c48494044b1159114b0748f63c84d5a9fbd6e599f5264267069841e7ccc3b71d5720f5802f5217cdccb743aff60c36e8e198148bd35f84a190e0c0a4e05c10a27d2a45a2184499286541e4053b109a9088eb6c28a4c5aceb61f89a0bb88351215f263430195f72075144a71e955b9c36922d17140bb67126134154afb93c9c48f3621d1e6f5b712558431e1a94af3bb29f0cef49f84eb60e260393e8f82c5c267801550ca17609362c41bced93283b75044964fd91749d8a2613b09b6af626433771dc59584ee25d53adb1ced5d6ac72e33e9e84f174d1c1c9584f4d9909984f4d0193c1e90b00b330a0c48ba35a6b9d4ba759ebc63d3b0903eaa2bf9331a09a321330a09a022683d3f7616635edf8a8799b31a60ca1b7affa68278e96eb629dccd05e969f8248139a800a62981d3e9a1b97b3b026e75a52adbbcacfd42c77e3999e841155af092639f3caa93101c7c9676d3230fd346e1646a35c3eaa3595f97f9af5c4fec749984bf63a6412c6122930015389b33519943cf99b8099b06faf0c9d04114c68efe243bc2bcae1a3ecced7d71456dee9b4725df20b5ec05dc38cf55736ae4466c105d709db997323c9e0084ec25690ec1d3b09c07a8b3504a583d20a049f2365208823a00540751208a46834a7ba1628c49c9301692cf31620441fca80345b590b9092b52400b0aae23a53ccade41ae213a7da6a5fe3f0b267eab9ae2722e35b41a24d1dce14d46a1ebcce656960441ff659858c306ab7a989e39421052b6f5a4248dda5235040bcb627d240efd43373eb51a8d772ae2180d21b27a1e71064905dd11209d1e66a3275365193a07596861e1a27d1481491dd4d1129d2e6fb30f57e5093a0f4af86201aa7c5480451de4d572b0ded81dcea486e3227ab93b4b15eea4029fe3e814820ddb1d0e46048614fedb41a7228ce732328543af62c4e5c754c693ba8508856568166b292f3458f8992e0776d20d775cb05ce0054152c178a5441cb2bb0dba14d9d4a1d5495386b9c3768f5d3da3ea3ce16c358780c2d7973be1e298b13b0815c6d7165ca871f8324cd2e4006ee4a3b75e56f8566fc714061b991d1688b5f5c2862cf91d6c5df550f3e81d291ccec6808f811cd695b9cb5caab22dc2a8bdd9c226913084122b995b28ac37c1ba98f7ceade9210370dcc2002ae864d3b1668a03a8783669e65e61d66a6658939047c8d8f86804bcc21909c39340c52660e859c8f6928aa33b31a4a95148706521575597d9cf246bef4b8ce022a4e7ec300c345e630a8ec37341caad81c1695df868645155bf27495e446e0e9aadc1c1ace6343c3c1252284e582d31a826f45504d82538bd573465a503802f65388bc9bc35e37b64218474d0ea03ac83d58467790420be1c2f75c19e17a90bcfc9e95695a2c673b96218eac2ecca2ec3bd66edac46c585daa8ee5a8a191db40bcd2b2834267cba021d1e5168250e5cc6044a12a3b38061c8af77ab0de549c4707b26928ba00b71a5a732d88d97c959785d490e81b1e342cddcd0f353492e881e363cb5d7728555ce769e026860b2d6c8a3a55036351d4a5072357c4fbd74faaaa8880bd4ca93a1eea96df3cf56334785dfa6a3c48788c72aaf663b33a6864cf68eaae87ca6a360bab3e72f1ba6ca5506433b146e35deec7197524d09e33d45d0f95339eb61252c2a89f2f3260ead283e1d9c6c5dd8f67ebc0b33dcfaabb1e2acf724f615995c4548dc9314f410ed8f7a80c424ccdc1c8038e80f49385d2ff672f07f26ee3c840f37c9361debad4e69041bdcf640f1a54c5c4eb2bc495f826f5e8757c898b232dab984efb772984200f6ee23a88503f02bf08f05cedd7ff0e8f8afaa3f24f72e788b4b80251700fd30c3f19767f2e3eb2c17cdbe270be33b148533f94c4c4a8d7d6923780133c790e0a82b63e6ab64d93affac84320cdd47619f9f0f1d4fd4fd9fbc4b9fce73701c01ba7f46b9d38c7ce7f07f84884291e4dcf5e08d05f9708e368836f2f36406c3f1ed11506fb6d88ae50484ccb8e94b8572f3232df8be88abdfc7310e52cfa7c0ca20b00e153105de74485bcba63237ee7a12b3af4671cda31e99c5eff79e8ca41e49a4dc6d25934e85c2b66403a64709f67d9ac77303e2fbaf9d6457af6d2756c4275d3c171af5e038b59d8bbd08fcdc13ea8129005600e958dc4bcdca62bd9f4ecb59a7c426fd3e149bf5e838b79c04d876f7af6e5e501b6b381b42b97febbd316cd25ff1e5847cb02312f7a5fe5933a3ee3fd591e1b79d1abdf81dc321b7f145b581eb078d1cbf5f4855502844be738b0d0cb43082f9a8ba4e93aa75dbec3664959aacc81d952f4e83f5996e4f33d76371e85748efd883e709ec403488d889f8b52684c9702718a37fb8a4727e2384f2cbba1d1b28d9cdbc6e7d877dc3436c62b3954bec26797a370be94844de60409c38c9a83704a8e79a63906e74c293807e368ae4acecb3a4f313fe09ce900e7601ecd6dca7999e7c9e6f63b842c7ed35a3a56eb3aa9b5f3d4b2f0cd99786fca8395e63eec7c27aaa792496faee479533288e292e87ccc416e434dc018dce5ccda63c967cbe0d749cc79a74c79872f619ebafe5d8c56143b95ba24c333c985271bab73c23c7dae3cf950b6a9f4b499f47443b48e40ceb0027c5221836e97826faf4dc027836f9d9e4f9b9d4f368275ee3e6dea3ed9085689fd9479fd6490710d0775d68c7fba247f12fdc4eb6faab354e2674de56784a2cae265c8a212fa03c9d32749cb67344de92c0798e48859f86449f7246f28269cec8809f6a4f9f4669dec24c9f38c909f586e47c885274d7f378bcea58e0a7d72dd09e9ed469d8c453e3bf17d1132a873d47b8bc39bc8904f834d0362896046d0634ce9bacd65741f138b9ec38834e1e2b05730033eb2b3cf922cb82fee0924b107d3b4fcaede6f20cc4b89bf83fe65749367bb3c435386dbbb90516bc5c940377e99b48fc5797953867ed321a680d00c8a4b8437d1791e847e8df747c975240588e2c85105c98bb5cc8a60f9665f43ba165e3baa0055e4ab4f4a5f20d28c08587a13adc10fd805b7af29fc0437c0db9357626a20ed0bc1927d7911804d02b66905a3e98f7e221ef6b78fbffc012ccff6dc249a0000, '6.1.3-40302');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Book_PublishingHouse_PublishingHouseId` (`PublishingHouseId`),
  ADD KEY `FK_Book_Supplier_SupplierId` (`SupplierId`),
  ADD KEY `FK_Book_Type_TypeId` (`TypeId`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `delivery`
--
ALTER TABLE `delivery`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `publishinghouse`
--
ALTER TABLE `publishinghouse`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Purchase_Client_ClientId` (`ClientId`),
  ADD KEY `FK_Purchase_Delivery_DeliveryId` (`DeliveryId`),
  ADD KEY `FK_Purchase_Employee_EmployeeId` (`EmployeeId`);

--
-- Indexes for table `purchased`
--
ALTER TABLE `purchased`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `FK_Purchased_Book_BookId` (`BookId`),
  ADD KEY `FK_Purchased_Purchase_PurchaseId` (`PurchaseId`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `__migrationhistory`
--
ALTER TABLE `__migrationhistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `delivery`
--
ALTER TABLE `delivery`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `publishinghouse`
--
ALTER TABLE `publishinghouse`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `type`
--
ALTER TABLE `type`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `book`
--
ALTER TABLE `book`
  ADD CONSTRAINT `FK_Book_PublishingHouse_PublishingHouseId` FOREIGN KEY (`PublishingHouseId`) REFERENCES `publishinghouse` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Book_Supplier_SupplierId` FOREIGN KEY (`SupplierId`) REFERENCES `supplier` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Book_Type_TypeId` FOREIGN KEY (`TypeId`) REFERENCES `type` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `purchase`
--
ALTER TABLE `purchase`
  ADD CONSTRAINT `FK_Purchase_Client_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `client` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Purchase_Delivery_DeliveryId` FOREIGN KEY (`DeliveryId`) REFERENCES `delivery` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Purchase_Employee_EmployeeId` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `purchased`
--
ALTER TABLE `purchased`
  ADD CONSTRAINT `FK_Purchased_Book_BookId` FOREIGN KEY (`BookId`) REFERENCES `book` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Purchased_Purchase_PurchaseId` FOREIGN KEY (`PurchaseId`) REFERENCES `purchase` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
