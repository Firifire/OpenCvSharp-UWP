set(the_description "datasets framework")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(datasets opencv_core opencv_imgcodecs opencv_ml opencv_flann opencv_text WRAP python)
ocv_warnings_disable(CMAKE_CXX_FLAGS /wd4267) # flann, Win64
