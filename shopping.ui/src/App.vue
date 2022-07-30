<template>
  <v-app>
    <v-col>
      <top-navigation />
    </v-col>
  </v-app>
</template>

<script lang="ts">
import { defineComponent } from "vue";

import TopNavigation from "./components/navigations/topNavigation/TopNavigation.vue";

export default defineComponent({
  name: "App",
  components: { TopNavigation },

  data() {
    return {};
  },
});
</script>
