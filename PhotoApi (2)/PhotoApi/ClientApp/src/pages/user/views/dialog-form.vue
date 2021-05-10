<template>
    <wtm-dialog-box :is-show.sync="isShow" :status="status" :events="formEvent">
        <wtm-create-form :ref="refName" :status="status" :options="formOptions" ></wtm-create-form>
    </wtm-dialog-box>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { Action, State } from "vuex-class";
import formMixin from "@/vue-custom/mixin/form-mixin";
import UploadImg from "@/components/page/UploadImg.vue";
import { SexTypeTypes } from "../config";

@Component({
    mixins: [formMixin()]
})
export default class Index extends Vue {

    // 表单结构
    get formOptions() {
        const filterMethod = (query, item) => {
            return item.label.indexOf(query) > -1;
        };
        return {
            formProps: {
                "label-width": "100px"
            },
            formItem: {
                "Entity.ID": {
                    isHidden: true
                },
             "Entity.UserName":{
                 label: "用户名",
                 rules: [{ required: true, message: "用户名"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "input"
            },
             "Entity.Password":{
                 label: "密码",
                 rules: [{ required: true, message: "密码"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "input"
            },
             "Entity.NickName":{
                 label: "昵称",
                 rules: [{ required: true, message: "昵称"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "input"
            },
             "Entity.SexType":{
                 label: "性别",
                 rules: [{ required: true, message: "性别"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "select",
                    children: SexTypeTypes,
                    props: {
                        clearable: true
                    }
            },
             "Entity.Email":{
                 label: "邮箱",
                 rules: [{ required: true, message: "邮箱"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "input"
            },
             "Entity.PhotoId":{
                 label: "头像",
                 rules: [],
                type: "wtmUploadImg",
                    props: {
                        isHead: true,
                        imageStyle: { width: "100px", height: "100px" }
                    }

            }
                
            }
        };
    }
    beforeOpen() {

    }
}
</script>
