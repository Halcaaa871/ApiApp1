<template>
    <div>
        <h1>お魚さんリスト</h1>
        <ul>
            <li v-for="fish in fishs" :key="fish.id">
                {{ fish.name }} - {{ fish.size }} - {{ fish.rearity }}
            </li>
        </ul>
    </div>
</template>

<script setup>
import {ref, onMounted} from 'vue'
import axios from 'axios'

const fishs = ref([])

onMounted(async () => {
    try{
        const res = await axios.get(`http://localhost:5030/api/FishCatch`)
        fishs.value = res.data//結果を代入
    }catch(error){
        console.error("データ取得エラー：", error)
    }
})
</script>