class SelfDump:

    def isEnabled(self):
        return True

    def getConfigurables(self):
        return []
        
    def dump(self, obj, level=0):
        if level > 10:
            return
        for a in dir(obj):
            if a.startswith('__'):
                continue
            val = getattr(obj, a)
            if isinstance(val, (int, float, str, list, dict, set)):
                print(level*" ", val)
            else:
                self.dump(val, level=level+1)

    def init(self, configuration):
        # Siehe https://github.com/sepinf-inc/IPED/blob/ac8ff26694413cf3c841f1548933e1dde288c0eb/iped-engine/src/main/java/iped/engine/task/ScriptTask.java#L92
        
        print("INIT - self")
        self.dump(self)
        
        # iped.engine.config.ConfigurationManager
        # https://github.com/sepinf-inc/IPED/blob/ac8ff26694413cf3c841f1548933e1dde288c0eb/iped-engine/src/main/java/iped/engine/config/ConfigurationManager.java
        print("INIT - configuration")
        self.dump(configuration)
        
        # iped.engine.data.CaseData
        # https://github.com/sepinf-inc/IPED/blob/ac8ff26694413cf3c841f1548933e1dde288c0eb/iped-engine/src/main/java/iped/engine/data/CaseData.java
        print("INIT - caseData")
        self.dump(caseData)
        
        # java.io.File
        print("INIT - moduleDir")
        self.dump(moduleDir)
        
        # iped.engine.core.Worker
        # https://github.com/sepinf-inc/IPED/blob/ac8ff26694413cf3c841f1548933e1dde288c0eb/iped-engine/src/main/java/iped/engine/core/Worker.java
        print("INIT - worker")
        self.dump(worker)
        
        # iped.engine.core.Statistics
        # https://github.com/sepinf-inc/IPED/blob/ac8ff26694413cf3c841f1548933e1dde288c0eb/iped-engine/src/main/java/iped/engine/core/Statistics.java
        print("INIT - stats")
        self.dump(stats)
    
    def finish(self):
        print("FINISH")
        self.dump(self)
    
    def process(self, item):
        print("PROCESS")
        self.dump(self)
        self.dump(item)
