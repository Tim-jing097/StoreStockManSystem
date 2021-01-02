/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50730
Source Host           : localhost:3306
Source Database       : storemana

Target Server Type    : MYSQL
Target Server Version : 50730
File Encoding         : 65001

Date: 2020-12-30 15:19:52
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin` (
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('123', '123', '1', 'XiaoWang');
INSERT INTO `admin` VALUES ('234', '234', '2', 'XiaoZhang');
INSERT INTO `admin` VALUES ('345', '345', '3', 'XiaoC');
INSERT INTO `admin` VALUES ('456', '456', '4', 'XiaoI');

-- ----------------------------
-- Table structure for custmorinfo
-- ----------------------------
DROP TABLE IF EXISTS `custmorinfo`;
CREATE TABLE `custmorinfo` (
  `bname` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `phonenum` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of custmorinfo
-- ----------------------------
INSERT INTO `custmorinfo` VALUES ('王老板', '111');
INSERT INTO `custmorinfo` VALUES ('李老板', '222');

-- ----------------------------
-- Table structure for thingsinfo
-- ----------------------------
DROP TABLE IF EXISTS `thingsinfo`;
CREATE TABLE `thingsinfo` (
  `vnum` char(255) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `stock` int(8) NOT NULL,
  `shortname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `begintime` date NOT NULL,
  `endtime` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of thingsinfo
-- ----------------------------
INSERT INTO `thingsinfo` VALUES ('sp001', '燃茶', '10', 'RC', '2020-01-01', '2022-02-02');
INSERT INTO `thingsinfo` VALUES ('sp002', '旺旺碎冰冰', '60', 'WWSBB', '2019-01-01', '2020-11-11');
INSERT INTO `thingsinfo` VALUES ('sp003', '旺仔牛奶', '60', 'WZNN', '2020-01-01', '2022-01-01');
INSERT INTO `thingsinfo` VALUES ('sp004', '沙琪玛', '40', 'SQM', '2021-11-01', '2023-11-01');
INSERT INTO `thingsinfo` VALUES ('sp005', '百事可乐', '62', 'BSKL', '2020-01-01', '2020-11-11');
INSERT INTO `thingsinfo` VALUES ('sp006', '可口可乐', '30', 'KKKL', '2020-01-01', '2022-01-01');
INSERT INTO `thingsinfo` VALUES ('sp007', '阿萨姆', '60', 'ASM', '2019-01-01', '2020-01-01');
