import Vue from "vue";
import VueI18n from "vue-i18n";

import { getLanguage } from "@/util/cookie";

// element-ui built-in lang
import elementEnLocale from "element-ui/lib/locale/lang/en";
import elementZhLocale from "element-ui/lib/locale/lang/zh-CN";
import elementEsLocale from "element-ui/lib/locale/lang/es";
import elementJaLocale from "element-ui/lib/locale/lang/ja";

// User defined lang
import enLocale from "./en";
import zhLocale from "./zh";
import esLocale from "./es";
import jaLocale from "./ja";

Vue.use(VueI18n);

const messages = {
  en: {
    ...enLocale,
    ...elementEnLocale
  },
  zh: {
    ...zhLocale,
    ...elementZhLocale
  },
  es: {
    ...esLocale,
    ...elementEsLocale
  },
  ja: {
    ...jaLocale,
    ...elementJaLocale
  }
};
const missing = (locale, key, vm) => {
  return key.substr(key.lastIndexOf(".") + 1);
};
export const getLocale = () => {
  const cookieLanguage = getLanguage();
  if (cookieLanguage) {
    return cookieLanguage;
  }

  const language = navigator.language.toLowerCase();
  const locales = Object.keys(messages);
  for (const locale of locales) {
    if (language.indexOf(locale) > -1) {
      return locale;
    }
  }
  return "zh";
};

const i18n = new VueI18n({
  locale: getLocale(),
  messages,
  missing
});

export default i18n;
