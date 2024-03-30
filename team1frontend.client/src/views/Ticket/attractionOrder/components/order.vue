<template>
  <el-table :data="filterTableData" style="width: 100%">
    <el-table-column label="Ticket" prop="date" />
    <el-table-column label="Description" prop="name" />
    <el-table-column label="" prop="name" />
    <el-table-column align="right">
      <template #header>
        <el-input v-model="search" size="small" placeholder="Type to search" />
      </template>
      <template #default="scope">
        <el-button size="small" @click="handleEdit(scope.$index, scope.row)">Edit</el-button>
        <el-button size="small" type="danger" @click="handleDelete(scope.$index, scope.row)">Delete</el-button>
      </template>
    </el-table-column>
  </el-table>
</template>
<script setup>
import { computed, ref } from 'vue'

const search = ref('')
const filterTableData = computed(() => {
  return tableData.value.filter(data =>
    !search.value || data.name.toLowerCase().includes(search.value.toLowerCase())
  )
})

const handleEdit = (index, row) => {
  console.log(index, row)
}

const handleDelete = (index, row) => {
  console.log(index, row)
  // 实际删除逻辑，如更新tableData
  tableData.value.splice(index, 1);
}

const tableData = ref([
  {
    date: '2016-05-03',
    name: 'Tom',
    address: 'No. 189, Grove St, Los Angeles',
  },
  {
    date: '2016-05-02',
    name: 'John',
    address: 'No. 189, Grove St, Los Angeles',
  },
  {
    date: '2016-05-04',
    name: 'Morgan',
    address: 'No. 189, Grove St, Los Angeles',
  },
  {
    date: '2016-05-01',
    name: 'Jessy',
    address: 'No. 189, Grove St, Los Angeles',
  },
])






</script>



<style scoped></style>