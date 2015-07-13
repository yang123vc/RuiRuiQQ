﻿using System;
using System.Collections.Generic;
// *   This program is free software: you can redistribute it and/or modify
// *   it under the terms of the GNU General Public License as published by
// *   the Free Software Foundation, either version 3 of the License, or
// *   (at your option) any later version.
// *
// *   This program is distributed in the hope that it will be useful,
// *   but WITHOUT ANY WARRANTY; without even the implied warranty of
// *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// *   GNU General Public License for more details.
// *
// *   You should have received a copy of the GNU General Public License
// *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// *
// * @author     Xianglong He
// * @copyright  Copyright (c) 2015 Xianglong He. (http://tec.hxlxz.com)
// * @license    http://www.gnu.org/licenses/     GPL v3
// * @version    1.0
// * @discribe   RuiRuiQQRobot服务端
// * 本软件作者是何相龙，使用GPL v3许可证进行授权。
namespace SmartQQ
{
    public class JsonFriendModel
    {
        public int retcode;
        public paramResult result;
        public class paramResult
        {
            /// 分组信息
            public List<paramCategories> categories;
            /// 好友汇总
            public List<paramFriends> friends;
            /// 好友信息
            public List<paramInfo> info;
            /// 备注
            public List<paramMarkNames> marknames;
            /// 分组
            public class paramCategories
            {
                public int index;
                public int sort;
                public string name;
            }
            /// 好友汇总 
            public class paramFriends
            {
                public int flag;
                public string uin;
                public int categories;
            }
            /// 好友信息
            public class paramInfo
            {
                public int face;
                public string nick;
                public string uin;
            }
            /// 备注 
            public class paramMarkNames
            {
                public string uin;
                public string markname;
            }
        }
    }
    public class JsonGroupModel
    {
        public int retcode;
        public paramResult result;
        public class paramResult
        {
            public List<paramGnamelist> gnamelist;
            public class paramGnamelist
            {
                public string flag;
                public string gid;
                public string code;
                public string name;
            }
        }
    }
    public class JsonFriendInfModel
    {
        public int retcode;
        public paramResult result;
        public class paramResult
        {
            public paramBirthday birthday;
            public string occupation;
            public string phone;
            public string college;
            public int constel;
            public int blood;
            public string homepage;
            public int stat;
            public string city;
            public string personal;
            public string nick;
            public int shengxiao;
            public string email;
            public string province;
            public string gender;
            public string mobile;
            public class paramBirthday
            {
                public int month;
                public int year;
                public int day;
            }
        }
    }
    public class JsonGroupInfoModel
    {
        public int retcode;
        public paramResult result;
        public class paramResult
        {
            public List<paramMinfo> minfo;
            public paramGinfo ginfo;
            public class paramMinfo
            {
                public string nick;
                public string province;
                public string gender;
                public string uin;
                public string country;
                public string city;
            }
            public class paramGinfo
            {
                public string code;
                public string createtime;
                public string flag;
                public string name;
                public string gid;
                public string owner;
                public List<paramMembers> members;
                public class paramMembers
                {
                    public string muin;
                    public int mflag;
                }
            }
        }
    }
    public class JsonHeartPackMessage
    {
        public int retcode;     //状态码
        public string errmsg;   //错误信息
        public string t;        //被迫下线说明
        public string p;        //需要更换的ptwebqq
        public List<paramResult> result;

        public class paramResult
        {
            public String poll_type;
            public paramValue value;
            public class paramValue
            {
                //收到消息
                public List<object> content;
                public string from_uin;
                //群消息有send_uin，为特征群号；info_seq为群号
                public string send_uin;
                public string info_seq;
                //上线提示
                public string uin;
                public string status;
                //异地登录
                public string reason;
            }
        }
    }
    public class JosnConfigFileModel
    {
        public String DicServer;
        public String DicPassword;
        public String QQNum;
        public String QQPassword;
        public int ClientID;
    }
    public class JsonExchangeRateModel
    {
        public bool success;
        public string error;
        public paramTicker ticker;
        public class paramTicker
        {
            public String price;
        }
    }
    public class JsonGroupManageModel
    {
        public string enable;
        public string enableWeather;
        public string enableExchangeRate;
        public string enableStock;
        public string enableStudy;
        public string enabletalk;
        public string enablexhj;
        public string enableEmoje;

        public string gno;
        public string statu;
        public string error;
    }
    public class JsonWeatherModel
    {
        public paramC c;
        public paramF f;
        public class paramC
        {
            public String c1;   //区域ID
            public String c2;   //城市英文名
            public String c3;   //城市中文名
            public String c4;   //城市所在市英文名
            public String c5;   //城市所在市中文名
            public String c6;   //城市所在省英文名
            public String c7;   //城市所在省中文名
            public String c8;   //城市所在国英文名
            public String c9;   //城市所在国中文名
            public String c10;  //城市级别
            public String c11;  //城市区号
            public String c12;  //邮编
            public String c13;  //经度
            public String c14;  //纬度
            public String c15;  //海拔
            public String c16;  //雷达站号
            public String c17;  //时区
        }
        public class paramF
        {
            public String f0;   //预报发布时间
            public List<paramF1> f1;
        }
        public class paramF1
        {
            public String fa;   //白天天气现象编号
            public String fb;   //晚上天气现象编号
            public String fc;   //白天气温
            public String fd;   //晚上气温
            public String fe;   //白天风向编号
            public String ff;   //晚上风向编号
            public String fg;   //白天风力编号
            public String fh;   //晚上风力编号
            public String fi;   //日出日落时间
        }
    }
    public class JsonWeatherIndexModel
    {
        public List<paramI> i;
        public class paramI
        {
            public string i1;   //指数简称
            public string i2;   //指数名称
            public string i3;   //指数别称
            public string i4;   //指数级别
            public string i5;   //级别说明
        }
    }
}
