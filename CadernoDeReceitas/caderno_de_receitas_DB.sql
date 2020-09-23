-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: cadernoreceitas
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `receitas`
--

DROP TABLE IF EXISTS `receitas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receitas` (
  `nome` varchar(128) NOT NULL,
  `dificuldade` varchar(8) NOT NULL,
  `ingrediente` longtext NOT NULL,
  `modoPreparo` longtext NOT NULL,
  `id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receitas`
--

LOCK TABLES `receitas` WRITE;
/*!40000 ALTER TABLE `receitas` DISABLE KEYS */;
INSERT INTO `receitas` VALUES ('Teste','Média','600g de água; 342g  de óleo; 311g de leite; 20g de sal; 1000g de polvilho azedo; 300g de ovos; 150g de parmesão ralado','Preaqueça o forno a 180 ºC (temperatura média). Numa tigela pequena, misture ½ colher (sopa) de farinha de trigo com 1 colher (sopa) de chocolate em pó para polvilhar a fôrma.\r\nUnte com manteiga uma fôrma redonda de 20 cm de diâmetro e 10 cm de altura. Corte um disco de papel-manteiga usando o fundo da fôrma como medida, pressione com os dedos para colar o papel no fundo untado e unte novamente com manteiga sobre o papel. Polvilhe o fundo e laterais da fôrma com a mistura de farinha e chocolate, bata bem sobre a pia para retirar o excesso.\r\nNuma tigela, misture a farinha com o chocolate em pó e reserve. Lave, seque e corte a maçã ao meio – nem precisa descascar. Retire as sementes, corte em pedaços médios e transfira a maçã para o liquidificador.\r\nNuma tigela pequena, quebre um ovo de cada vez e junte à maçã – se um estiver estragado você não perde a receita. Acrescente o café, o óleo, os açúcares e bata bem até formar ficar liso.\r\nTransfira para uma tigela e acrescente a mistura de secos, em etapas, passando pela peneira. Misture delicadamente com o batedor de arame para incorporar. Por último, misture o fermento em pó.\r\nColoque a massa na fôrma preparada e gire sobre a bancada para nivelar. Leve ao forno para assar por cerca de 1 hora – para verificar, espete um palito: se sair limpo, está pronto, caso contrário deixe assar por mais alguns minutos. Enquanto isso, aproveite para preparar a pasta de chocolate e amendoim.\r\nRetire do forno e deixe o bolo esfriar completamente antes de desenformar.',11),('a','Difícil','600g de água; 342g  de óleo; 311g de leite; 20g de sal; 1000g de polvilho azedo; 300g de ovos; 150g de parmesão ralado','a',12);
/*!40000 ALTER TABLE `receitas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-23  7:11:01
