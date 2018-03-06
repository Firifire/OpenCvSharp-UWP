if(CV_ICC AND NOT MSVC)
  ocv_module_disable(saliency)
endif()

set(the_description "Saliency API")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(saliency opencv_imgproc opencv_features2d WRAP python)

ocv_warnings_disable(CMAKE_CXX_FLAGS -Woverloaded-virtual)
