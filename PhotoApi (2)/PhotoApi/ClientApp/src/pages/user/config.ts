import i18n from "@/lang";

export const ASSEMBLIES: Array<string> = [
  "add",
  "edit",
  "delete",
  "export",
  "imported"
];

export const TABLE_HEADER: Array<object> = [


    {
        key: "UserName",
        label: "用户名"
    },
    {
        key: "Password",
        label: "密码"
    },
    {
        key: "NickName",
        label: "昵称"
    },
    {
        key: "SexType",
        label: "性别"
    },
    {
        key: "Email",
        label: "邮箱"
    },
    {
        key: "PhotoId",
        label: "头像",
        isSlot: true 
    },
  { isOperate: true, label: i18n.t(`table.actions`), actions: ["detail", "edit", "deleted"] } //操作列
];

export const SexTypeTypes: Array<any> = [
  { Text: "男", Value: 0 },
  { Text: "女", Value: 1 }
];

