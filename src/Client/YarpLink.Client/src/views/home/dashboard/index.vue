<template>
    <div v-if="pageLoading">
        <el-main>
            <el-card shadow="never">
                <el-skeleton :rows="1"></el-skeleton>
            </el-card>
            <el-card shadow="never" style="margin-top: 15px">
                <el-skeleton></el-skeleton>
            </el-card>
        </el-main>
    </div>
    <work v-if="dashboard === '0'" @on-mounted="onMounted"></work>
    <widgets v-else @on-mounted="onMounted"></widgets>
</template>

<script>
import { defineAsyncComponent } from "vue";

const work = defineAsyncComponent(() => import("./work"));
const widgets = defineAsyncComponent(() => import("./widgets"));

export default {
    components: {
        work,
        widgets,
    },
    data() {
        return {
            pageLoading: true,
            dashboard: "0",
        };
    },
    created() {
        this.dashboard =
            this.$TOOL.data
                .get("USER_INFO")
                .roles.findIndex((x) => x.displayDashboard) >= 0
                ? "1"
                : "0";
    },
    mounted() {},
    methods: {
        onMounted() {
            this.pageLoading = false;
        },
    },
};
</script>

<style></style>