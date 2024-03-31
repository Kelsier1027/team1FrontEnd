<template>
    <div class="hello">
      <h1>{{ msg }}</h1>
      <button @click="onClickButton" >連線測試</button>
    </div>
  </template>
  <script>
  export default {
    name: 'index',
    props: {
      msg: String
    },
    data() {
      return {
      };
    },
    methods: {
      onClickButton() {
          console.log(this.$signalr)
          this.$signalr
              .invoke('SendMessage', "hmy")
              .catch(function(err) {return console.error(err) })
      }
    }
  }
  </script>
  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  h3 {
    margin: 40px 0 0;
  }
  ul {
    list-style-type: none;
    padding: 0;
  }
  li {
    display: inline-block;
    margin: 0 10px;
  }
  a {
    color: #42b983;
  }
  </style>