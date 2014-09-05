from __future__ import print_function
import shutil
with open('py_dbg.txt', 'w') as f:
    with open('conf.config','r') as conf:
        target = conf.readline().rstrip()
        print(target,file=f)
        try:
            print('try copy',file=f)
            shutil.copyfile(target,"Problem.cs")
            print('copy finished!',file =f)
        except: print('copy failed',file=f)
        else : print("target file does not exist",file=f)
