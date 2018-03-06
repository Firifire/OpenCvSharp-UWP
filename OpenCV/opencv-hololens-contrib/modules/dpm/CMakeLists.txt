set(the_description "Object Detection")

#uncomment the following line to enable parallel computing
#add_definitions(-DHAVE_TBB)

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(dpm opencv_core opencv_imgproc opencv_objdetect OPTIONAL opencv_highgui WRAP python)

ocv_warnings_disable(CMAKE_CXX_FLAGS /wd4512) # disable warning on Win64
