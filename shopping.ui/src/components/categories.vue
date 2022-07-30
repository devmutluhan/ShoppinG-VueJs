<template>
  <v-container>
    <v-tabs> <v-tab> </v-tab> </v-tabs>
    <v-tabs-items> <v-tab-item> </v-tab-item> </v-tabs-items>
  </v-container>
</template>

<script lang="ts">
import Vue from "vue";
import { Category } from "../models/entities/Category";
import { CategoryService } from "../services/Membership/CategoryService";

export default {
  name: "Categories",
  data() {
    return {
      categoryService: new CategoryService(),
      categories: new Array<Category>(),
      currentTab: 0,
    };
  },
  methods: {
    getCategories() {},
  },
};
</script>

<style>
</style>