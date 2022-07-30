<template>
  <v-container fluid>
    <v-row>
      <v-col cols="2">
        <router-link to="/" class="text-decoration-none">
          <span
            style="font-family: 'BhuTuka Expanded One', cursive"
            class="
              text-xs-h6
              text-sm-h5
              text-md-h4
              text-lg-h3
              text-xl-h2
              text-weight-thin
            "
            color="#9E9D24s"
            >ShoppinG
          </span>
        </router-link>
      </v-col>
      <v-col cols="4">
        <v-text-field placeholder="Arama" dense rounded></v-text-field>
      </v-col>
      <v-col cols="2"> Konum </v-col>
      <v-col cols="2"> Profil </v-col>
      <v-col cols="2"> Sepetim </v-col>
    </v-row>
    <v-row>
      <v-col>
        <v-tabs v-model="tab" align-with-title grow>
          <v-tab v-for="item in categories" :key="item" :value="item">
            {{ item }}
          </v-tab>
        </v-tabs>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang='ts'>
import { defineComponent } from "vue";

export default defineComponent({
  name: "TopNavigation",

  data() {
    return {
      tab: null,
      categories: ["web", "shopping", "videos", "images", "news"],
    };
  },
});
</script>

<style>
@import url("https://fonts.googleapis.com/css2?family=BhuTuka+Expanded+One&family=Cormorant+SC:wght@500&display=swap");
</style>