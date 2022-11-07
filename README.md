# TestOptimize
 
Project used for optimization testing

First test with 1.000 units, 100 units per line, all render

- No optimization: Batches: 6002, FPS 16.5
- Dynamic Batching enable: Batches: 5037, FPS: 19
- Replace SkinedMeshRender with MeshRender: Batches: 5037, FPS: 24
- Enable GPU Instancing on material: Batches: 18, FPS: 26
- Disable animation due to high Animation.Update usage according to Profiler: Batches: 18, FPS: 110

Second test with 10.000 units, 500 units per line, all render

- No optimization: Batches: 60002, FPS: 1.5
- Dynamic batching enable: Batches: 50347, FPS: 1.5
- Replace SkinedMeshRender with MeshRender: Batches: 50347, FPS: 2
- Enable GPU Instancing on material: Batches 124, FPS: 2.5
- Disable animation due to high Animation.Update usage according to Profiler: Batches: 124, FPS: 12


Third test with 100.000 units, 1.000 units per line

- No optimization: Unknown result, unity took 10 mins and still unable to run
- Dynamic batching enable: Unknown result, unity took 10 mins and still unable to run
- Replace SkinedMeshRender with MeshRender: No test due to the risk of unity crash again
- Enable GPU Instancing on material: Unknown result, unity took 10 mins and still unable to run
- Disable animation due to high Animation.Update usage according to Profiler: Unknown result, unity took 10 mins and still unable to run